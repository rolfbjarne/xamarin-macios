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
	[Register("GKAccessPoint", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class GKAccessPoint : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameInScreenCoordinatesX = "frameInScreenCoordinates";
		static readonly NativeHandle selFrameInScreenCoordinatesXHandle = Selector.GetHandle ("frameInScreenCoordinates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsActiveX = "isActive";
		static readonly NativeHandle selIsActiveXHandle = Selector.GetHandle ("isActive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPresentingGameCenterX = "isPresentingGameCenter";
		static readonly NativeHandle selIsPresentingGameCenterXHandle = Selector.GetHandle ("isPresentingGameCenter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVisibleX = "isVisible";
		static readonly NativeHandle selIsVisibleXHandle = Selector.GetHandle ("isVisible");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationX = "location";
		static readonly NativeHandle selLocationXHandle = Selector.GetHandle ("location");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentWindowX = "parentWindow";
		static readonly NativeHandle selParentWindowXHandle = Selector.GetHandle ("parentWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActive_X = "setActive:";
		static readonly NativeHandle selSetActive_XHandle = Selector.GetHandle ("setActive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocation_X = "setLocation:";
		static readonly NativeHandle selSetLocation_XHandle = Selector.GetHandle ("setLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParentWindow_X = "setParentWindow:";
		static readonly NativeHandle selSetParentWindow_XHandle = Selector.GetHandle ("setParentWindow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShowHighlights_X = "setShowHighlights:";
		static readonly NativeHandle selSetShowHighlights_XHandle = Selector.GetHandle ("setShowHighlights:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedX = "shared";
		static readonly NativeHandle selSharedXHandle = Selector.GetHandle ("shared");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowHighlightsX = "showHighlights";
		static readonly NativeHandle selShowHighlightsXHandle = Selector.GetHandle ("showHighlights");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointForArcadeWithHandler_X = "triggerAccessPointForArcadeWithHandler:";
		static readonly NativeHandle selTriggerAccessPointForArcadeWithHandler_XHandle = Selector.GetHandle ("triggerAccessPointForArcadeWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointForChallengesWithHandler_X = "triggerAccessPointForChallengesWithHandler:";
		static readonly NativeHandle selTriggerAccessPointForChallengesWithHandler_XHandle = Selector.GetHandle ("triggerAccessPointForChallengesWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointForFriendingWithHandler_X = "triggerAccessPointForFriendingWithHandler:";
		static readonly NativeHandle selTriggerAccessPointForFriendingWithHandler_XHandle = Selector.GetHandle ("triggerAccessPointForFriendingWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointForPlayTogetherWithHandler_X = "triggerAccessPointForPlayTogetherWithHandler:";
		static readonly NativeHandle selTriggerAccessPointForPlayTogetherWithHandler_XHandle = Selector.GetHandle ("triggerAccessPointForPlayTogetherWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithAchievementID_Handler_X = "triggerAccessPointWithAchievementID:handler:";
		static readonly NativeHandle selTriggerAccessPointWithAchievementID_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithAchievementID:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithChallengeDefinitionID_Handler_X = "triggerAccessPointWithChallengeDefinitionID:handler:";
		static readonly NativeHandle selTriggerAccessPointWithChallengeDefinitionID_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithChallengeDefinitionID:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithGameActivity_Handler_X = "triggerAccessPointWithGameActivity:handler:";
		static readonly NativeHandle selTriggerAccessPointWithGameActivity_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithGameActivity:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithGameActivityDefinitionID_Handler_X = "triggerAccessPointWithGameActivityDefinitionID:handler:";
		static readonly NativeHandle selTriggerAccessPointWithGameActivityDefinitionID_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithGameActivityDefinitionID:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithHandler_X = "triggerAccessPointWithHandler:";
		static readonly NativeHandle selTriggerAccessPointWithHandler_XHandle = Selector.GetHandle ("triggerAccessPointWithHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithLeaderboardID_PlayerScope_TimeScope_Handler_X = "triggerAccessPointWithLeaderboardID:playerScope:timeScope:handler:";
		static readonly NativeHandle selTriggerAccessPointWithLeaderboardID_PlayerScope_TimeScope_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithLeaderboardID:playerScope:timeScope:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithLeaderboardSetID_Handler_X = "triggerAccessPointWithLeaderboardSetID:handler:";
		static readonly NativeHandle selTriggerAccessPointWithLeaderboardSetID_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithLeaderboardSetID:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithPlayer_Handler_X = "triggerAccessPointWithPlayer:handler:";
		static readonly NativeHandle selTriggerAccessPointWithPlayer_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithPlayer:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTriggerAccessPointWithState_Handler_X = "triggerAccessPointWithState:handler:";
		static readonly NativeHandle selTriggerAccessPointWithState_Handler_XHandle = Selector.GetHandle ("triggerAccessPointWithState:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKAccessPoint");
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
		protected GKAccessPoint (NSObjectFlag t) : base (t)
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
		protected internal GKAccessPoint (NativeHandle handle) : base (handle)
		{
		}

		[Export ("triggerAccessPointWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPoint ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTriggerAccessPointWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTriggerAccessPointWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointWithState:handler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPoint (GKGameCenterViewControllerState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action handler)
		{
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDAction.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selTriggerAccessPointWithState_Handler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selTriggerAccessPointWithState_Handler_XHandle, (IntPtr) (long) state, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointWithLeaderboardID:playerScope:timeScope:handler:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPoint (string leaderboardId, GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (leaderboardId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardId));
			var nsleaderboardId = CFString.CreateNative (leaderboardId);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (this.Handle, selTriggerAccessPointWithLeaderboardID_PlayerScope_TimeScope_Handler_XHandle, nsleaderboardId, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_NativeHandle (&__objc_super__, selTriggerAccessPointWithLeaderboardID_PlayerScope_TimeScope_Handler_XHandle, nsleaderboardId, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsleaderboardId);
		}
		[Export ("triggerAccessPointWithPlayer:handler:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPoint (GKPlayer player, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithPlayer_Handler_XHandle, player__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithPlayer_Handler_XHandle, player__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("triggerAccessPointForArcadeWithHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.2")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointForArcade ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTriggerAccessPointForArcadeWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTriggerAccessPointForArcadeWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointForChallengesWithHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointForChallenges ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTriggerAccessPointForChallengesWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTriggerAccessPointForChallengesWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointForFriendingWithHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointForFriending ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTriggerAccessPointForFriendingWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTriggerAccessPointForFriendingWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointForPlayTogetherWithHandler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointForPlayTogether ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTriggerAccessPointForPlayTogetherWithHandler_XHandle, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTriggerAccessPointForPlayTogetherWithHandler_XHandle, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("triggerAccessPointWithAchievementID:handler:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointWithAchievementId (string achievementId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (achievementId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievementId));
			var nsachievementId = CFString.CreateNative (achievementId);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithAchievementID_Handler_XHandle, nsachievementId, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithAchievementID_Handler_XHandle, nsachievementId, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsachievementId);
		}
		[Export ("triggerAccessPointWithChallengeDefinitionID:handler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointWithChallengeDefinitionId (string challengeDefinitionId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (challengeDefinitionId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (challengeDefinitionId));
			var nschallengeDefinitionId = CFString.CreateNative (challengeDefinitionId);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithChallengeDefinitionID_Handler_XHandle, nschallengeDefinitionId, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithChallengeDefinitionID_Handler_XHandle, nschallengeDefinitionId, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nschallengeDefinitionId);
		}
		[Export ("triggerAccessPointWithGameActivity:handler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointWithGameActivity (GKGameActivity gameActivity, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			var gameActivity__handle__ = gameActivity!.GetNonNullHandle (nameof (gameActivity));
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithGameActivity_Handler_XHandle, gameActivity__handle__, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithGameActivity_Handler_XHandle, gameActivity__handle__, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gameActivity);
		}
		[Export ("triggerAccessPointWithGameActivityDefinitionID:handler:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointWithGameActivityDefinitionId (string gameActivityDefinitionId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (gameActivityDefinitionId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gameActivityDefinitionId));
			var nsgameActivityDefinitionId = CFString.CreateNative (gameActivityDefinitionId);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithGameActivityDefinitionID_Handler_XHandle, nsgameActivityDefinitionId, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithGameActivityDefinitionID_Handler_XHandle, nsgameActivityDefinitionId, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsgameActivityDefinitionId);
		}
		[Export ("triggerAccessPointWithLeaderboardSetID:handler:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TriggerAccessPointWithLeaderboardSetId (string leaderboardSetId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (leaderboardSetId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardSetId));
			var nsleaderboardSetId = CFString.CreateNative (leaderboardSetId);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTriggerAccessPointWithLeaderboardSetID_Handler_XHandle, nsleaderboardSetId, (IntPtr) block_ptr_handler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTriggerAccessPointWithLeaderboardSetID_Handler_XHandle, nsleaderboardSetId, (IntPtr) block_ptr_handler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsleaderboardSetId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Active {
			[Export ("isActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsActiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsActiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setActive:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetActive_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetActive_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect FrameInScreenCoordinates {
			[Export ("frameInScreenCoordinates")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selFrameInScreenCoordinatesXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selFrameInScreenCoordinatesXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selFrameInScreenCoordinatesXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selFrameInScreenCoordinatesXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPresentingGameCenter {
			[Export ("isPresentingGameCenter")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsPresentingGameCenterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsPresentingGameCenterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKAccessPointLocation Location {
			[Export ("location", ArgumentSemantic.Assign)]
			get {
				GKAccessPointLocation ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKAccessPointLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKAccessPointLocation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLocationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLocation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocation_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetLocation_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ParentWindow_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSWindow? ParentWindow {
			[Export ("parentWindow", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSWindow? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ParentWindow_var = ret;
				return ret!;
			}
			[Export ("setParentWindow:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParentWindow_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParentWindow_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_ParentWindow_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKAccessPoint Shared {
			[Export ("shared")]
			get {
				GKAccessPoint? ret;
				ret =  Runtime.GetNSObject<GKAccessPoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios26.0", "Unsupported.")]
		[ObsoletedOSPlatform ("macos26.0", "Unsupported.")]
		[ObsoletedOSPlatform ("tvos26.0", "Unsupported.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Unsupported.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowHighlights {
			[Export ("showHighlights")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowHighlightsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShowHighlightsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowHighlights:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowHighlights_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShowHighlights_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Visible {
			[Export ("isVisible")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVisibleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVisibleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParentWindow_var = null;
			}
		}
	} /* class GKAccessPoint */
}
