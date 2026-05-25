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
	[Register("GKGameActivity", true)]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	public unsafe partial class GKGameActivity : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAchievementsX = "achievements";
		static readonly NativeHandle selAchievementsXHandle = Selector.GetHandle ("achievements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivityDefinitionX = "activityDefinition";
		static readonly NativeHandle selActivityDefinitionXHandle = Selector.GetHandle ("activityDefinition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCheckPendingGameActivityExistenceWithCompletionHandler_X = "checkPendingGameActivityExistenceWithCompletionHandler:";
		static readonly NativeHandle selCheckPendingGameActivityExistenceWithCompletionHandler_XHandle = Selector.GetHandle ("checkPendingGameActivityExistenceWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationDateX = "creationDate";
		static readonly NativeHandle selCreationDateXHandle = Selector.GetHandle ("creationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndX = "end";
		static readonly NativeHandle selEndXHandle = Selector.GetHandle ("end");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndDateX = "endDate";
		static readonly NativeHandle selEndDateXHandle = Selector.GetHandle ("endDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindMatchWithCompletionHandler_X = "findMatchWithCompletionHandler:";
		static readonly NativeHandle selFindMatchWithCompletionHandler_XHandle = Selector.GetHandle ("findMatchWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFindPlayersForHostedMatchWithCompletionHandler_X = "findPlayersForHostedMatchWithCompletionHandler:";
		static readonly NativeHandle selFindPlayersForHostedMatchWithCompletionHandler_XHandle = Selector.GetHandle ("findPlayersForHostedMatchWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetProgressOnAchievement_X = "getProgressOnAchievement:";
		static readonly NativeHandle selGetProgressOnAchievement_XHandle = Selector.GetHandle ("getProgressOnAchievement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetScoreOnLeaderboard_X = "getScoreOnLeaderboard:";
		static readonly NativeHandle selGetScoreOnLeaderboard_XHandle = Selector.GetHandle ("getScoreOnLeaderboard:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDefinition_X = "initWithDefinition:";
		static readonly NativeHandle selInitWithDefinition_XHandle = Selector.GetHandle ("initWithDefinition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsValidPartyCode_X = "isValidPartyCode:";
		static readonly NativeHandle selIsValidPartyCode_XHandle = Selector.GetHandle ("isValidPartyCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastResumeDateX = "lastResumeDate";
		static readonly NativeHandle selLastResumeDateXHandle = Selector.GetHandle ("lastResumeDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeaderboardScoresX = "leaderboardScores";
		static readonly NativeHandle selLeaderboardScoresXHandle = Selector.GetHandle ("leaderboardScores");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeMatchRequestX = "makeMatchRequest";
		static readonly NativeHandle selMakeMatchRequestXHandle = Selector.GetHandle ("makeMatchRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPartyCodeX = "partyCode";
		static readonly NativeHandle selPartyCodeXHandle = Selector.GetHandle ("partyCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPartyURLX = "partyURL";
		static readonly NativeHandle selPartyURLXHandle = Selector.GetHandle ("partyURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertiesX = "properties";
		static readonly NativeHandle selPropertiesXHandle = Selector.GetHandle ("properties");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAchievements_X = "removeAchievements:";
		static readonly NativeHandle selRemoveAchievements_XHandle = Selector.GetHandle ("removeAchievements:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveScoresFromLeaderboards_X = "removeScoresFromLeaderboards:";
		static readonly NativeHandle selRemoveScoresFromLeaderboards_XHandle = Selector.GetHandle ("removeScoresFromLeaderboards:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeX = "resume";
		static readonly NativeHandle selResumeXHandle = Selector.GetHandle ("resume");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAchievementCompleted_X = "setAchievementCompleted:";
		static readonly NativeHandle selSetAchievementCompleted_XHandle = Selector.GetHandle ("setAchievementCompleted:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProgressOnAchievement_ToPercentComplete_X = "setProgressOnAchievement:toPercentComplete:";
		static readonly NativeHandle selSetProgressOnAchievement_ToPercentComplete_XHandle = Selector.GetHandle ("setProgressOnAchievement:toPercentComplete:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProperties_X = "setProperties:";
		static readonly NativeHandle selSetProperties_XHandle = Selector.GetHandle ("setProperties:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScoreOnLeaderboard_ToScore_X = "setScoreOnLeaderboard:toScore:";
		static readonly NativeHandle selSetScoreOnLeaderboard_ToScore_XHandle = Selector.GetHandle ("setScoreOnLeaderboard:toScore:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScoreOnLeaderboard_ToScore_Context_X = "setScoreOnLeaderboard:toScore:context:";
		static readonly NativeHandle selSetScoreOnLeaderboard_ToScore_Context_XHandle = Selector.GetHandle ("setScoreOnLeaderboard:toScore:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartX = "start";
		static readonly NativeHandle selStartXHandle = Selector.GetHandle ("start");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartDateX = "startDate";
		static readonly NativeHandle selStartDateXHandle = Selector.GetHandle ("startDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartWithDefinition_Error_X = "startWithDefinition:error:";
		static readonly NativeHandle selStartWithDefinition_Error_XHandle = Selector.GetHandle ("startWithDefinition:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartWithDefinition_PartyCode_Error_X = "startWithDefinition:partyCode:error:";
		static readonly NativeHandle selStartWithDefinition_PartyCode_Error_XHandle = Selector.GetHandle ("startWithDefinition:partyCode:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateX = "state";
		static readonly NativeHandle selStateXHandle = Selector.GetHandle ("state");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidPartyCodeAlphabetX = "validPartyCodeAlphabet";
		static readonly NativeHandle selValidPartyCodeAlphabetXHandle = Selector.GetHandle ("validPartyCodeAlphabet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKGameActivity");
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
		protected GKGameActivity (NSObjectFlag t) : base (t)
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
		protected internal GKGameActivity (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDefinition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameActivity (GKGameActivityDefinition activityDefinition)
			: base (NSObjectFlag.Empty)
		{
			var activityDefinition__handle__ = activityDefinition!.GetNonNullHandle (nameof (activityDefinition));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDefinition_XHandle, activityDefinition__handle__), "initWithDefinition:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDefinition_XHandle, activityDefinition__handle__), "initWithDefinition:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (activityDefinition);
		}
		[Export ("checkPendingGameActivityExistenceWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CheckPendingGameActivityExistence ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKGameActivityCheckPendingGameActivityExistenceHandler))]GKGameActivityCheckPendingGameActivityExistenceHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGKGameActivityCheckPendingGameActivityExistenceHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selCheckPendingGameActivityExistenceWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<bool> CheckPendingGameActivityExistenceAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			CheckPendingGameActivityExistence((pendingGameActivityExists_) => {
				tcs.SetResult (pendingGameActivityExists_!);
			});
			return tcs.Task;
		}
		[Export ("startWithDefinition:partyCode:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKGameActivity? Create (GKGameActivityDefinition activityDefinition, string partyCode, out NSError? error)
		{
			var activityDefinition__handle__ = activityDefinition!.GetNonNullHandle (nameof (activityDefinition));
			if (partyCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (partyCode));
			NativeHandle errorValue = IntPtr.Zero;
			var nspartyCode = CFString.CreateNative (partyCode);
			GKGameActivity? ret;
			ret =  Runtime.GetNSObject<GKGameActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selStartWithDefinition_PartyCode_Error_XHandle, activityDefinition__handle__, nspartyCode, &errorValue), false)!;
			GC.KeepAlive (activityDefinition);
			CFString.ReleaseNative (nspartyCode);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("startWithDefinition:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKGameActivity? Create (GKGameActivityDefinition activityDefinition, out NSError? error)
		{
			var activityDefinition__handle__ = activityDefinition!.GetNonNullHandle (nameof (activityDefinition));
			NativeHandle errorValue = IntPtr.Zero;
			GKGameActivity? ret;
			ret =  Runtime.GetNSObject<GKGameActivity> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selStartWithDefinition_Error_XHandle, activityDefinition__handle__, &errorValue), false)!;
			GC.KeepAlive (activityDefinition);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("end")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void End ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEndXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEndXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("findMatchWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindMatch ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKGameActivityFindMatchHandler))]GKGameActivityFindMatchHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGKGameActivityFindMatchHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFindMatchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFindMatchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKMatch> FindMatchAsync ()
		{
			var tcs = new TaskCompletionSource<GKMatch> ();
			FindMatch((match_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (match_!);
			});
			return tcs.Task;
		}
		[Export ("findPlayersForHostedMatchWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FindPlayersForHostedMatch ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKGameActivityFindPlayersForHostedMatchHandler))]GKGameActivityFindPlayersForHostedMatchHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDGKGameActivityFindPlayersForHostedMatchHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFindPlayersForHostedMatchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFindPlayersForHostedMatchWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer> FindPlayersForHostedMatchAsync ()
		{
			var tcs = new TaskCompletionSource<GKPlayer> ();
			FindPlayersForHostedMatch((match_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (match_!);
			});
			return tcs.Task;
		}
		[Export ("getProgressOnAchievement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetProgressOnAchievement (GKAchievement achievement)
		{
			var achievement__handle__ = achievement!.GetNonNullHandle (nameof (achievement));
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, selGetProgressOnAchievement_XHandle, achievement__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetProgressOnAchievement_XHandle, achievement__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (achievement);
			return ret!;
		}
		[Export ("getScoreOnLeaderboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKLeaderboardScore? GetScore (GKLeaderboard leaderboard)
		{
			var leaderboard__handle__ = leaderboard!.GetNonNullHandle (nameof (leaderboard));
			GKLeaderboardScore? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GKLeaderboardScore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetScoreOnLeaderboard_XHandle, leaderboard__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GKLeaderboardScore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetScoreOnLeaderboard_XHandle, leaderboard__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leaderboard);
			return ret!;
		}
		[Export ("isValidPartyCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidPartyCode (string partyCode)
		{
			if (partyCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (partyCode));
			var nspartyCode = CFString.CreateNative (partyCode);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selIsValidPartyCode_XHandle, nspartyCode);
			CFString.ReleaseNative (nspartyCode);
			return ret != 0;
		}
		[Export ("makeMatchRequest")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKMatchRequest? MakeMatchRequest ()
		{
			GKMatchRequest ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GKMatchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMakeMatchRequestXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GKMatchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMakeMatchRequestXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAchievements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAchievements (GKAchievement[] achievements)
		{
			if (achievements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievements));
			using var nsa_achievements = NSArray.FromNSObjects (achievements);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAchievements_XHandle, nsa_achievements.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAchievements_XHandle, nsa_achievements.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeScoresFromLeaderboards:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveScores (GKLeaderboard[] leaderboards)
		{
			if (leaderboards is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboards));
			using var nsa_leaderboards = NSArray.FromNSObjects (leaderboards);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveScoresFromLeaderboards_XHandle, nsa_leaderboards.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveScoresFromLeaderboards_XHandle, nsa_leaderboards.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resume")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResumeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResumeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setAchievementCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAchievementCompleted (GKAchievement achievement)
		{
			var achievement__handle__ = achievement!.GetNonNullHandle (nameof (achievement));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAchievementCompleted_XHandle, achievement__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAchievementCompleted_XHandle, achievement__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (achievement);
		}
		[Export ("setProgressOnAchievement:toPercentComplete:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProgressOnAchievement (GKAchievement achievement, double percentComplete)
		{
			var achievement__handle__ = achievement!.GetNonNullHandle (nameof (achievement));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, selSetProgressOnAchievement_ToPercentComplete_XHandle, achievement__handle__, percentComplete);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double (&__objc_super__, selSetProgressOnAchievement_ToPercentComplete_XHandle, achievement__handle__, percentComplete);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (achievement);
		}
		[Export ("setScoreOnLeaderboard:toScore:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScore (GKLeaderboard leaderboard, nint score, nuint context)
		{
			var leaderboard__handle__ = leaderboard!.GetNonNullHandle (nameof (leaderboard));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_UIntPtr (this.Handle, selSetScoreOnLeaderboard_ToScore_Context_XHandle, leaderboard__handle__, score, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_UIntPtr (&__objc_super__, selSetScoreOnLeaderboard_ToScore_Context_XHandle, leaderboard__handle__, score, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leaderboard);
		}
		[Export ("setScoreOnLeaderboard:toScore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetScore (GKLeaderboard leaderboard, nint score)
		{
			var leaderboard__handle__ = leaderboard!.GetNonNullHandle (nameof (leaderboard));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetScoreOnLeaderboard_ToScore_XHandle, leaderboard__handle__, score);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetScoreOnLeaderboard_ToScore_XHandle, leaderboard__handle__, score);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leaderboard);
		}
		[Export ("start")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStartXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GKAchievement> Achievements {
			[Export ("achievements", ArgumentSemantic.Copy)]
			get {
				NSSet<GKAchievement>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GKAchievement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAchievementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GKAchievement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAchievementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKGameActivityDefinition ActivityDefinition {
			[Export ("activityDefinition", ArgumentSemantic.Retain)]
			get {
				GKGameActivityDefinition? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKGameActivityDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActivityDefinitionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKGameActivityDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActivityDefinitionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate CreationDate {
			[Export ("creationDate", ArgumentSemantic.Retain)]
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
		public virtual NSDate? EndDate {
			[Export ("endDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEndDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEndDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? LastResumeDate {
			[Export ("lastResumeDate", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastResumeDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastResumeDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GKLeaderboardScore> LeaderboardScores {
			[Export ("leaderboardScores", ArgumentSemantic.Copy)]
			get {
				NSSet<GKLeaderboardScore>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GKLeaderboardScore>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeaderboardScoresXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GKLeaderboardScore>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeaderboardScoresXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PartyCode {
			[Export ("partyCode")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPartyCodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPartyCodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? PartyUrl {
			[Export ("partyURL", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPartyURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPartyURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSString> Properties {
			[Export ("properties", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, NSString>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPropertiesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPropertiesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProperties:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProperties_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProperties_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		public virtual GKGameActivityState State {
			[Export ("state", ArgumentSemantic.Assign)]
			get {
				GKGameActivityState ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKGameActivityState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKGameActivityState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ValidPartyCodeAlphabet {
			[Export ("validPartyCodeAlphabet", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selValidPartyCodeAlphabetXHandle), false)!;
				return ret;
			}
		}
	} /* class GKGameActivity */
}
