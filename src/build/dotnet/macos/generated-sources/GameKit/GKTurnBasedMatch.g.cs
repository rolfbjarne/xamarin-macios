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
	[Register("GKTurnBasedMatch", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKTurnBasedMatch : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptInviteWithCompletionHandler_X = "acceptInviteWithCompletionHandler:";
		static readonly NativeHandle selAcceptInviteWithCompletionHandler_XHandle = Selector.GetHandle ("acceptInviteWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveExchangesX = "activeExchanges";
		static readonly NativeHandle selActiveExchangesXHandle = Selector.GetHandle ("activeExchanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletedExchangesX = "completedExchanges";
		static readonly NativeHandle selCompletedExchangesXHandle = Selector.GetHandle ("completedExchanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationDateX = "creationDate";
		static readonly NativeHandle selCreationDateXHandle = Selector.GetHandle ("creationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentParticipantX = "currentParticipant";
		static readonly NativeHandle selCurrentParticipantXHandle = Selector.GetHandle ("currentParticipant");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeclineInviteWithCompletionHandler_X = "declineInviteWithCompletionHandler:";
		static readonly NativeHandle selDeclineInviteWithCompletionHandler_XHandle = Selector.GetHandle ("declineInviteWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndMatchInTurnWithMatchData_CompletionHandler_X = "endMatchInTurnWithMatchData:completionHandler:";
		static readonly NativeHandle selEndMatchInTurnWithMatchData_CompletionHandler_XHandle = Selector.GetHandle ("endMatchInTurnWithMatchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndMatchInTurnWithMatchData_LeaderboardScores_Achievements_CompletionHandler_X = "endMatchInTurnWithMatchData:leaderboardScores:achievements:completionHandler:";
		static readonly NativeHandle selEndMatchInTurnWithMatchData_LeaderboardScores_Achievements_CompletionHandler_XHandle = Selector.GetHandle ("endMatchInTurnWithMatchData:leaderboardScores:achievements:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_X = "endMatchInTurnWithMatchData:scores:achievements:completionHandler:";
		static readonly NativeHandle selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_XHandle = Selector.GetHandle ("endMatchInTurnWithMatchData:scores:achievements:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndTurnWithNextParticipant_MatchData_CompletionHandler_X = "endTurnWithNextParticipant:matchData:completionHandler:";
		static readonly NativeHandle selEndTurnWithNextParticipant_MatchData_CompletionHandler_XHandle = Selector.GetHandle ("endTurnWithNextParticipant:matchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_X = "endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:";
		static readonly NativeHandle selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle = Selector.GetHandle ("endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeDataMaximumSizeX = "exchangeDataMaximumSize";
		static readonly NativeHandle selExchangeDataMaximumSizeXHandle = Selector.GetHandle ("exchangeDataMaximumSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeMaxInitiatedExchangesPerPlayerX = "exchangeMaxInitiatedExchangesPerPlayer";
		static readonly NativeHandle selExchangeMaxInitiatedExchangesPerPlayerXHandle = Selector.GetHandle ("exchangeMaxInitiatedExchangesPerPlayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangesX = "exchanges";
		static readonly NativeHandle selExchangesXHandle = Selector.GetHandle ("exchanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindMatchForRequest_WithCompletionHandler_X = "findMatchForRequest:withCompletionHandler:";
		static readonly NativeHandle selFindMatchForRequest_WithCompletionHandler_XHandle = Selector.GetHandle ("findMatchForRequest:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMatchDataWithCompletionHandler_X = "loadMatchDataWithCompletionHandler:";
		static readonly NativeHandle selLoadMatchDataWithCompletionHandler_XHandle = Selector.GetHandle ("loadMatchDataWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMatchWithID_WithCompletionHandler_X = "loadMatchWithID:withCompletionHandler:";
		static readonly NativeHandle selLoadMatchWithID_WithCompletionHandler_XHandle = Selector.GetHandle ("loadMatchWithID:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadMatchesWithCompletionHandler_X = "loadMatchesWithCompletionHandler:";
		static readonly NativeHandle selLoadMatchesWithCompletionHandler_XHandle = Selector.GetHandle ("loadMatchesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchDataX = "matchData";
		static readonly NativeHandle selMatchDataXHandle = Selector.GetHandle ("matchData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchDataMaximumSizeX = "matchDataMaximumSize";
		static readonly NativeHandle selMatchDataMaximumSizeXHandle = Selector.GetHandle ("matchDataMaximumSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchIDX = "matchID";
		static readonly NativeHandle selMatchIDXHandle = Selector.GetHandle ("matchID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageX = "message";
		static readonly NativeHandle selMessageXHandle = Selector.GetHandle ("message");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_X = "participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:";
		static readonly NativeHandle selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_XHandle = Selector.GetHandle ("participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_X = "participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:";
		static readonly NativeHandle selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle = Selector.GetHandle ("participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_X = "participantQuitOutOfTurnWithOutcome:withCompletionHandler:";
		static readonly NativeHandle selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_XHandle = Selector.GetHandle ("participantQuitOutOfTurnWithOutcome:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParticipantsX = "participants";
		static readonly NativeHandle selParticipantsXHandle = Selector.GetHandle ("participants");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRematchWithCompletionHandler_X = "rematchWithCompletionHandler:";
		static readonly NativeHandle selRematchWithCompletionHandler_XHandle = Selector.GetHandle ("rematchWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveWithCompletionHandler_X = "removeWithCompletionHandler:";
		static readonly NativeHandle selRemoveWithCompletionHandler_XHandle = Selector.GetHandle ("removeWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveCurrentTurnWithMatchData_CompletionHandler_X = "saveCurrentTurnWithMatchData:completionHandler:";
		static readonly NativeHandle selSaveCurrentTurnWithMatchData_CompletionHandler_XHandle = Selector.GetHandle ("saveCurrentTurnWithMatchData:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_X = "saveMergedMatchData:withResolvedExchanges:completionHandler:";
		static readonly NativeHandle selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_XHandle = Selector.GetHandle ("saveMergedMatchData:withResolvedExchanges:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_X = "sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:";
		static readonly NativeHandle selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_XHandle = Selector.GetHandle ("sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_X = "sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:";
		static readonly NativeHandle selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_XHandle = Selector.GetHandle ("sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalizableMessageWithKey_Arguments_X = "setLocalizableMessageWithKey:arguments:";
		static readonly NativeHandle selSetLocalizableMessageWithKey_Arguments_XHandle = Selector.GetHandle ("setLocalizableMessageWithKey:arguments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMessage_X = "setMessage:";
		static readonly NativeHandle selSetMessage_XHandle = Selector.GetHandle ("setMessage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKTurnBasedMatch");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKTurnBasedMatch" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKTurnBasedMatch () : base (NSObjectFlag.Empty)
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
		protected GKTurnBasedMatch (NSObjectFlag t) : base (t)
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
		protected internal GKTurnBasedMatch (NativeHandle handle) : base (handle)
		{
		}

		[Export ("acceptInviteWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AcceptInvite ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<GKTurnBasedMatch, NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V100.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAcceptInviteWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAcceptInviteWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously accepts an invitation to a match.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous AcceptInvite operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKTurnBasedMatch,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKTurnBasedMatch> AcceptInviteAsync ()
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch> ();
			AcceptInvite((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("declineInviteWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeclineInvite ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<GKTurnBasedMatch, NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V100.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeclineInviteWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeclineInviteWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously declines an invitation to a match.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous DeclineInvite operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKTurnBasedMatch,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKTurnBasedMatch> DeclineInviteAsync ()
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch> ();
			DeclineInvite((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("endMatchInTurnWithMatchData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndMatchInTurn (NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? onCompletion)
		{
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var block_onCompletion = Trampolines.SDActionArity1V16.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEndMatchInTurnWithMatchData_CompletionHandler_XHandle, matchData__handle__, (IntPtr) block_ptr_onCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEndMatchInTurnWithMatchData_CompletionHandler_XHandle, matchData__handle__, (IntPtr) block_ptr_onCompletion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="matchData">To be added.</param>
		/// <summary>Asynchronously ends the match with the specified end state, scores, and achievements.</summary>
		/// <returns>A task that represents the asynchronous EndMatchInTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EndMatchInTurnAsync (NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EndMatchInTurn(matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("endMatchInTurnWithMatchData:scores:achievements:completionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndMatchInTurn (NSData matchData, GKScore[]? scores, GKAchievement[]? achievements, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var nsa_scores = scores is null ? null : NSArray.FromNSObjects (scores);
			using var nsa_achievements = achievements is null ? null : NSArray.FromNSObjects (achievements);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_XHandle, matchData__handle__, nsa_scores.GetHandle (), nsa_achievements.GetHandle (), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_XHandle, matchData__handle__, nsa_scores.GetHandle (), nsa_achievements.GetHandle (), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="matchData">To be added.</param>
		/// <param name="scores">To be added.</param>
		/// <param name="achievements">To be added.</param>
		/// <summary>Asynchronously the specified end state, scores, and achievements.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'EndMatchInTurn (NSData, GKLeaderboardScore[], NSObject[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EndMatchInTurnAsync (NSData matchData, GKScore[]? scores, GKAchievement[]? achievements)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EndMatchInTurn(matchData, scores, achievements, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("endMatchInTurnWithMatchData:leaderboardScores:achievements:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndMatchInTurn (NSData matchData, GKLeaderboardScore[] scores, NSObject[] achievements, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			if (scores is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scores));
			if (achievements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievements));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_scores = NSArray.FromNSObjects (scores);
			using var nsa_achievements = NSArray.FromNSObjects (achievements);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEndMatchInTurnWithMatchData_LeaderboardScores_Achievements_CompletionHandler_XHandle, matchData__handle__, nsa_scores.Handle, nsa_achievements.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEndMatchInTurnWithMatchData_LeaderboardScores_Achievements_CompletionHandler_XHandle, matchData__handle__, nsa_scores.Handle, nsa_achievements.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EndMatchInTurnAsync (NSData matchData, GKLeaderboardScore[] scores, NSObject[] achievements)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EndMatchInTurn(matchData, scores, achievements, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndTurn (GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (nextParticipants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nextParticipants));
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var nsa_nextParticipants = NSArray.FromNSObjects (nextParticipants);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double_NativeHandle_NativeHandle (this.Handle, selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle, nsa_nextParticipants.Handle, timeoutSeconds, matchData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double_NativeHandle_NativeHandle (&__objc_super__, selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle, nsa_nextParticipants.Handle, timeoutSeconds, matchData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="nextParticipants">To be added.</param>
		/// <param name="timeoutSeconds">To be added.</param>
		/// <param name="matchData">To be added.</param>
		/// <summary>Asynchronously ends the turn.</summary>
		/// <returns>A task that represents the asynchronous EndTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EndTurnAsync (GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EndTurn(nextParticipants, timeoutSeconds, matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("endTurnWithNextParticipant:matchData:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'EndTurn' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'EndTurn' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'EndTurn' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EndTurnWithNextParticipant (GKTurnBasedParticipant nextParticipant, NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? noCompletion)
		{
			var nextParticipant__handle__ = nextParticipant!.GetNonNullHandle (nameof (nextParticipant));
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var block_noCompletion = Trampolines.SDActionArity1V16.CreateNullableBlock (noCompletion);
			BlockLiteral *block_ptr_noCompletion = null;
			if (noCompletion is not null)
				block_ptr_noCompletion = &block_noCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEndTurnWithNextParticipant_MatchData_CompletionHandler_XHandle, nextParticipant__handle__, matchData__handle__, (IntPtr) block_ptr_noCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEndTurnWithNextParticipant_MatchData_CompletionHandler_XHandle, nextParticipant__handle__, matchData__handle__, (IntPtr) block_ptr_noCompletion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nextParticipant);
			GC.KeepAlive (matchData);
		}
		/// <param name="nextParticipant">To be added.</param>
		/// <param name="matchData">To be added.</param>
		/// <summary>Developers should not use this deprecated method. Developers should use 'EndTurn' instead.</summary>
		/// <returns>A task that represents the asynchronous EndTurnWithNextParticipant operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'EndTurn' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'EndTurn' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'EndTurn' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task EndTurnWithNextParticipantAsync (GKTurnBasedParticipant nextParticipant, NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			EndTurnWithNextParticipant(nextParticipant, matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("findMatchForRequest:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void FindMatch (GKMatchRequest request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKTurnBasedMatchRequest))]GKTurnBasedMatchRequest onCompletion)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (onCompletion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onCompletion));
			using var block_onCompletion = Trampolines.SDGKTurnBasedMatchRequest.CreateBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = &block_onCompletion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFindMatchForRequest_WithCompletionHandler_XHandle, request__handle__, (IntPtr) block_ptr_onCompletion);
			GC.KeepAlive (request);
		}
		/// <param name="request">To be added.</param>
		/// <summary>Asynchronously searches for and returns a match to join.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous FindMatch operation.   The value of the TResult parameter is a GameKit.GKTurnBasedMatchRequest.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKTurnBasedMatch> FindMatchAsync (GKMatchRequest request)
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch> ();
			FindMatch(request, (match_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (match_!);
			});
			return tcs.Task;
		}
		[Export ("loadMatchWithID:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadMatch (string matchId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<GKTurnBasedMatch, NSError>? completionHandler)
		{
			if (matchId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (matchId));
			var nsmatchId = CFString.CreateNative (matchId);
			using var block_completionHandler = Trampolines.SDActionArity2V100.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLoadMatchWithID_WithCompletionHandler_XHandle, nsmatchId, (IntPtr) block_ptr_completionHandler);
			CFString.ReleaseNative (nsmatchId);
		}
		/// <param name="matchId">To be added.</param>
		/// <summary>Asynchronously loads the match that is identified by <paramref name="matchId" /> and returns it (<see langword="null" /> if an error occurs).</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous LoadMatch operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKTurnBasedMatch,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKTurnBasedMatch> LoadMatchAsync (string matchId)
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch> ();
			LoadMatch(matchId, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadMatchDataWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadMatchData ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKTurnBasedMatchData))]GKTurnBasedMatchData? onCompletion)
		{
			using var block_onCompletion = Trampolines.SDGKTurnBasedMatchData.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadMatchDataWithCompletionHandler_XHandle, (IntPtr) block_ptr_onCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadMatchDataWithCompletionHandler_XHandle, (IntPtr) block_ptr_onCompletion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously loads the match data.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadMatchData operation.   The value of the TResult parameter is a GameKit.GKTurnBasedMatchData.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadMatchDataAsync ()
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadMatchData((matchData_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (matchData_!);
			});
			return tcs.Task;
		}
		[Export ("loadMatchesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadMatches ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKTurnBasedMatchesRequest))]GKTurnBasedMatchesRequest? onCompletion)
		{
			using var block_onCompletion = Trampolines.SDGKTurnBasedMatchesRequest.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selLoadMatchesWithCompletionHandler_XHandle, (IntPtr) block_ptr_onCompletion);
		}
		/// <summary>Asynchronously loads all the matches for the current player.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadMatches operation.   The value of the TResult parameter is a GameKit.GKTurnBasedMatchesRequest.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKTurnBasedMatch[]> LoadMatchesAsync ()
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch[]> ();
			LoadMatches((matches_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (matches_!);
			});
			return tcs.Task;
		}
		[Export ("participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ParticipantQuitInTurn (GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant nextParticipant, NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? onCompletion)
		{
			var nextParticipant__handle__ = nextParticipant!.GetNonNullHandle (nameof (nextParticipant));
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var block_onCompletion = Trampolines.SDActionArity1V16.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_NativeHandle_NativeHandle (this.Handle, selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_XHandle, (IntPtr) (long) matchOutcome, nextParticipant__handle__, matchData__handle__, (IntPtr) block_ptr_onCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_XHandle, (IntPtr) (long) matchOutcome, nextParticipant__handle__, matchData__handle__, (IntPtr) block_ptr_onCompletion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nextParticipant);
			GC.KeepAlive (matchData);
		}
		/// <param name="matchOutcome">To be added.</param>
		/// <param name="nextParticipant">To be added.</param>
		/// <param name="matchData">To be added.</param>
		/// <summary>Deprecated.</summary>
		/// <returns>A task that represents the asynchronous ParticipantQuitInTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[ObsoletedOSPlatform ("macos10.9", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ParticipantQuitInTurnAsync (GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant nextParticipant, NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ParticipantQuitInTurn(matchOutcome, nextParticipant, matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ParticipantQuitInTurn (GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (nextParticipants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nextParticipants));
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var nsa_nextParticipants = NSArray.FromNSObjects (nextParticipants);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle_Double_NativeHandle_NativeHandle (this.Handle, selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle, (IntPtr) (long) matchOutcome, nsa_nextParticipants.Handle, timeoutSeconds, matchData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle_Double_NativeHandle_NativeHandle (&__objc_super__, selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_XHandle, (IntPtr) (long) matchOutcome, nsa_nextParticipants.Handle, timeoutSeconds, matchData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="matchOutcome">To be added.</param>
		/// <param name="nextParticipants">To be added.</param>
		/// <param name="timeoutSeconds">To be added.</param>
		/// <param name="matchData">To be added.</param>
		/// <summary>Asynchronously resigns the current player from the match.</summary>
		/// <returns>A task that represents the asynchronous ParticipantQuitInTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ParticipantQuitInTurnAsync (GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ParticipantQuitInTurn(matchOutcome, nextParticipants, timeoutSeconds, matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("participantQuitOutOfTurnWithOutcome:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ParticipantQuitOutOfTurn (GKTurnBasedMatchOutcome matchOutcome, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? onCompletion)
		{
			using var block_onCompletion = Trampolines.SDActionArity1V16.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_XHandle, (IntPtr) (long) matchOutcome, (IntPtr) block_ptr_onCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_XHandle, (IntPtr) (long) matchOutcome, (IntPtr) block_ptr_onCompletion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="matchOutcome">To be added.</param>
		/// <summary>Asynchronously resigns the player from the match out of turn.</summary>
		/// <returns>A task that represents the asynchronous ParticipantQuitOutOfTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ParticipantQuitOutOfTurnAsync (GKTurnBasedMatchOutcome matchOutcome)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ParticipantQuitOutOfTurn(matchOutcome, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("rematchWithCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Rematch ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V100))]global::System.Action<GKTurnBasedMatch, NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity2V100.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRematchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRematchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Creates a new match with the same list of participants as the current match.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous Rematch operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKTurnBasedMatch,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKTurnBasedMatch> RematchAsync ()
		{
			var tcs = new TaskCompletionSource<GKTurnBasedMatch> ();
			Rematch((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("removeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Remove ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? onCompletion)
		{
			using var block_onCompletion = Trampolines.SDActionArity1V16.CreateNullableBlock (onCompletion);
			BlockLiteral *block_ptr_onCompletion = null;
			if (onCompletion is not null)
				block_ptr_onCompletion = &block_onCompletion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveWithCompletionHandler_XHandle, (IntPtr) block_ptr_onCompletion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveWithCompletionHandler_XHandle, (IntPtr) block_ptr_onCompletion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously removes the match from the Game Center.</summary>
		/// <returns>A task that represents the asynchronous Remove operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RemoveAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			Remove((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("saveCurrentTurnWithMatchData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveCurrentTurn (NSData matchData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSaveCurrentTurnWithMatchData_CompletionHandler_XHandle, matchData__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSaveCurrentTurnWithMatchData_CompletionHandler_XHandle, matchData__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="matchData">To be added.</param>
		/// <summary>Asynchronously saves the current turn, does not advance to the next player.</summary>
		/// <returns>A task that represents the asynchronous SaveCurrentTurn operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SaveCurrentTurnAsync (NSData matchData)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SaveCurrentTurn(matchData, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("saveMergedMatchData:withResolvedExchanges:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveMergedMatchData (NSData matchData, GKTurnBasedExchange[] exchanges, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			var matchData__handle__ = matchData!.GetNonNullHandle (nameof (matchData));
			if (exchanges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (exchanges));
			using var nsa_exchanges = NSArray.FromNSObjects (exchanges);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_XHandle, matchData__handle__, nsa_exchanges.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_XHandle, matchData__handle__, nsa_exchanges.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matchData);
		}
		/// <param name="matchData">To be added.</param>
		/// <param name="exchanges">To be added.</param>
		/// <summary>Asynchronously saves merged match data without advancing play.</summary>
		/// <returns>A task that represents the asynchronous SaveMergedMatchData operation</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SaveMergedMatchDataAsync (NSData matchData, GKTurnBasedExchange[] exchanges)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SaveMergedMatchData(matchData, exchanges, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendExchange (GKTurnBasedParticipant[] participants, NSData data, string localizableMessage, NSObject[] arguments, double timeout, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V101))]global::System.Action<GKTurnBasedExchange, NSError>? completionHandler)
		{
			if (participants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participants));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (localizableMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizableMessage));
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_participants = NSArray.FromNSObjects (participants);
			var nslocalizableMessage = CFString.CreateNative (localizableMessage);
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			using var block_completionHandler = Trampolines.SDActionArity2V101.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_Double_NativeHandle (this.Handle, selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_XHandle, nsa_participants.Handle, data__handle__, nslocalizableMessage, nsa_arguments.Handle, timeout, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_Double_NativeHandle (&__objc_super__, selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_XHandle, nsa_participants.Handle, data__handle__, nslocalizableMessage, nsa_arguments.Handle, timeout, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nslocalizableMessage);
		}
		/// <param name="participants">To be added.</param>
		/// <param name="data">To be added.</param>
		/// <param name="localizableMessage">To be added.</param>
		/// <param name="arguments">To be added.</param>
		/// <param name="timeout">To be added.</param>
		/// <summary>Sends exchange requests to the players who are listed in <paramref name="participants" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SendExchange operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKTurnBasedExchange,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKTurnBasedExchange> SendExchangeAsync (GKTurnBasedParticipant[] participants, NSData data, string localizableMessage, NSObject[] arguments, double timeout)
		{
			var tcs = new TaskCompletionSource<GKTurnBasedExchange> ();
			SendExchange(participants, data, localizableMessage, arguments, timeout, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendReminder (GKTurnBasedParticipant[] participants, string localizableMessage, NSObject[] arguments, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (participants is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participants));
			if (localizableMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizableMessage));
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			using var nsa_participants = NSArray.FromNSObjects (participants);
			var nslocalizableMessage = CFString.CreateNative (localizableMessage);
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_XHandle, nsa_participants.Handle, nslocalizableMessage, nsa_arguments.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_XHandle, nsa_participants.Handle, nslocalizableMessage, nsa_arguments.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizableMessage);
		}
		/// <param name="participants">To be added.</param>
		/// <param name="localizableMessage">To be added.</param>
		/// <param name="arguments">To be added.</param>
		/// <summary>Sends a reminder to the players who are listed in <paramref name="participants" />.</summary>
		/// <returns>A task that represents the asynchronous SendReminder operation</returns>
		/// <remarks>
		///           <para copied="true">The SendReminderAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SendReminderAsync (GKTurnBasedParticipant[] participants, string localizableMessage, NSObject[] arguments)
		{
			var tcs = new TaskCompletionSource<bool> ();
			SendReminder(participants, localizableMessage, arguments, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("setLocalizableMessageWithKey:arguments:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMessage (string localizableMessage, params NSObject[]? arguments)
		{
			if (localizableMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizableMessage));
			var nslocalizableMessage = CFString.CreateNative (localizableMessage);
			using var nsa_arguments = arguments is null ? null : NSArray.FromNSObjects (arguments);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetLocalizableMessageWithKey_Arguments_XHandle, nslocalizableMessage, nsa_arguments.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetLocalizableMessageWithKey_Arguments_XHandle, nslocalizableMessage, nsa_arguments.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizableMessage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GKTurnBasedExchange[]? ActiveExchanges {
			[Export ("activeExchanges", ArgumentSemantic.Retain)]
			get {
				GKTurnBasedExchange[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveExchangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveExchangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GKTurnBasedExchange[]? CompletedExchanges {
			[Export ("completedExchanges", ArgumentSemantic.Retain)]
			get {
				GKTurnBasedExchange[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompletedExchangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompletedExchangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? CreationDate {
			[Export ("creationDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedParticipant? CurrentParticipant {
			[Export ("currentParticipant", ArgumentSemantic.Retain)]
			get {
				GKTurnBasedParticipant? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKTurnBasedParticipant> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentParticipantXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKTurnBasedParticipant> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentParticipantXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint ExchangeMaxInitiatedExchangesPerPlayer {
			[Export ("exchangeMaxInitiatedExchangesPerPlayer")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selExchangeMaxInitiatedExchangesPerPlayerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selExchangeMaxInitiatedExchangesPerPlayerXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GKTurnBasedExchange[]? Exchanges {
			[Export ("exchanges", ArgumentSemantic.Retain)]
			get {
				GKTurnBasedExchange[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExchangesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedExchange>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExchangesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint ExhangeDataMaximumSize {
			[Export ("exchangeDataMaximumSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selExchangeDataMaximumSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selExchangeDataMaximumSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? MatchData {
			[Export ("matchData", ArgumentSemantic.Retain)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MatchDataMaximumSize {
			[Export ("matchDataMaximumSize")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMatchDataMaximumSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMatchDataMaximumSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MatchID {
			[Export ("matchID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Message {
			[Export ("message", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMessageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMessageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMessage:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMessage_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMessage_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedParticipant[]? Participants {
			[Export ("participants", ArgumentSemantic.Retain)]
			get {
				GKTurnBasedParticipant[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedParticipant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParticipantsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedParticipant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParticipantsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedMatchStatus Status {
			[Export ("status")]
			get {
				GKTurnBasedMatchStatus ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKTurnBasedMatchStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKTurnBasedMatchStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Represents the value associated with the constant GKTurnTimeoutDefault</summary><value></value><remarks>To be added.</remarks>
		[Field ("GKTurnTimeoutDefault",  "GameKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static double DefaultTimeout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetDouble (Libraries.GameKit.Handle, "GKTurnTimeoutDefault");
			}
		}
		/// <summary>Represents the value associated with the constant GKTurnTimeoutNone</summary><value></value><remarks>To be added.</remarks>
		[Field ("GKTurnTimeoutNone",  "GameKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static double NoTimeout {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetDouble (Libraries.GameKit.Handle, "GKTurnTimeoutNone");
			}
		}
	} /* class GKTurnBasedMatch */
}
