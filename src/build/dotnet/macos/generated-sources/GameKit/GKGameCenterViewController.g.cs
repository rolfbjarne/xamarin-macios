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
	[Register("GKGameCenterViewController", true)]
	[ObsoletedOSPlatform ("ios26.0")]
	[ObsoletedOSPlatform ("macos26.0")]
	[ObsoletedOSPlatform ("tvos26.0")]
	[ObsoletedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKGameCenterViewController : global::AppKit.NSViewController, IGKViewController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGameCenterDelegateX = "gameCenterDelegate";
		static readonly NativeHandle selGameCenterDelegateXHandle = Selector.GetHandle ("gameCenterDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAchievementID_X = "initWithAchievementID:";
		static readonly NativeHandle selInitWithAchievementID_XHandle = Selector.GetHandle ("initWithAchievementID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeaderboard_PlayerScope_X = "initWithLeaderboard:playerScope:";
		static readonly NativeHandle selInitWithLeaderboard_PlayerScope_XHandle = Selector.GetHandle ("initWithLeaderboard:playerScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeaderboardID_PlayerScope_TimeScope_X = "initWithLeaderboardID:playerScope:timeScope:";
		static readonly NativeHandle selInitWithLeaderboardID_PlayerScope_TimeScope_XHandle = Selector.GetHandle ("initWithLeaderboardID:playerScope:timeScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeaderboardSetID_X = "initWithLeaderboardSetID:";
		static readonly NativeHandle selInitWithLeaderboardSetID_XHandle = Selector.GetHandle ("initWithLeaderboardSetID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithNibName_Bundle_X = "initWithNibName:bundle:";
		static readonly NativeHandle selInitWithNibName_Bundle_XHandle = Selector.GetHandle ("initWithNibName:bundle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPlayer_X = "initWithPlayer:";
		static readonly NativeHandle selInitWithPlayer_XHandle = Selector.GetHandle ("initWithPlayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithState_X = "initWithState:";
		static readonly NativeHandle selInitWithState_XHandle = Selector.GetHandle ("initWithState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeaderboardCategoryX = "leaderboardCategory";
		static readonly NativeHandle selLeaderboardCategoryXHandle = Selector.GetHandle ("leaderboardCategory");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeaderboardIdentifierX = "leaderboardIdentifier";
		static readonly NativeHandle selLeaderboardIdentifierXHandle = Selector.GetHandle ("leaderboardIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeaderboardTimeScopeX = "leaderboardTimeScope";
		static readonly NativeHandle selLeaderboardTimeScopeXHandle = Selector.GetHandle ("leaderboardTimeScope");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGameCenterDelegate_X = "setGameCenterDelegate:";
		static readonly NativeHandle selSetGameCenterDelegate_XHandle = Selector.GetHandle ("setGameCenterDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLeaderboardCategory_X = "setLeaderboardCategory:";
		static readonly NativeHandle selSetLeaderboardCategory_XHandle = Selector.GetHandle ("setLeaderboardCategory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLeaderboardIdentifier_X = "setLeaderboardIdentifier:";
		static readonly NativeHandle selSetLeaderboardIdentifier_XHandle = Selector.GetHandle ("setLeaderboardIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLeaderboardTimeScope_X = "setLeaderboardTimeScope:";
		static readonly NativeHandle selSetLeaderboardTimeScope_XHandle = Selector.GetHandle ("setLeaderboardTimeScope:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetViewState_X = "setViewState:";
		static readonly NativeHandle selSetViewState_XHandle = Selector.GetHandle ("setViewState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selViewStateX = "viewState";
		static readonly NativeHandle selViewStateXHandle = Selector.GetHandle ("viewState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKGameCenterViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public GKGameCenterViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected GKGameCenterViewController (NSObjectFlag t) : base (t)
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
		protected internal GKGameCenterViewController (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="nibNameOrNull">To be added.</param><param name="nibBundleOrNull">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithNibName:bundle:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameCenterViewController (string? nibNameOrNull, NSBundle? nibBundleOrNull)
			: base (NSObjectFlag.Empty)
		{
			var nibBundleOrNull__handle__ = nibBundleOrNull.GetHandle ();
			var nsnibNameOrNull = CFString.CreateNative (nibNameOrNull);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithNibName_Bundle_XHandle, nsnibNameOrNull, nibBundleOrNull__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (nibBundleOrNull);
			CFString.ReleaseNative (nsnibNameOrNull);
		}
		[Export ("initWithLeaderboardID:playerScope:timeScope:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameCenterViewController (string leaderboardId, GKLeaderboardPlayerScope playerScope, GKLeaderboardTimeScope timeScope)
			: base (NSObjectFlag.Empty)
		{
			if (leaderboardId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardId));
			var nsleaderboardId = CFString.CreateNative (leaderboardId);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr (this.Handle, selInitWithLeaderboardID_PlayerScope_TimeScope_XHandle, nsleaderboardId, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope), "initWithLeaderboardID:playerScope:timeScope:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr (&__objc_super__, selInitWithLeaderboardID_PlayerScope_TimeScope_XHandle, nsleaderboardId, (IntPtr) (long) playerScope, (IntPtr) (long) timeScope), "initWithLeaderboardID:playerScope:timeScope:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsleaderboardId);
		}
		[Export ("initWithLeaderboard:playerScope:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameCenterViewController (GKLeaderboard leaderboard, GKLeaderboardPlayerScope playerScope)
			: base (NSObjectFlag.Empty)
		{
			var leaderboard__handle__ = leaderboard!.GetNonNullHandle (nameof (leaderboard));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInitWithLeaderboard_PlayerScope_XHandle, leaderboard__handle__, (IntPtr) (long) playerScope), "initWithLeaderboard:playerScope:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInitWithLeaderboard_PlayerScope_XHandle, leaderboard__handle__, (IntPtr) (long) playerScope), "initWithLeaderboard:playerScope:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (leaderboard);
		}
		[Export ("initWithState:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameCenterViewController (GKGameCenterViewControllerState state)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selInitWithState_XHandle, (IntPtr) (long) state), "initWithState:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selInitWithState_XHandle, (IntPtr) (long) state), "initWithState:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithPlayer:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKGameCenterViewController (GKPlayer player)
			: base (NSObjectFlag.Empty)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPlayer_XHandle, player__handle__), "initWithPlayer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPlayer_XHandle, player__handle__), "initWithPlayer:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
		}
		[Export ("initWithAchievementID:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithAchievementId (string achievementId)
		{
			if (achievementId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievementId));
			var nsachievementId = CFString.CreateNative (achievementId);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithAchievementID_XHandle, nsachievementId);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithAchievementID_XHandle, nsachievementId);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsachievementId);
			return ret!;
		}
		[Export ("initWithLeaderboardSetID:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithLeaderboardSetId (string leaderboardSetId)
		{
			if (leaderboardSetId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardSetId));
			var nsleaderboardSetId = CFString.CreateNative (leaderboardSetId);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithLeaderboardSetID_XHandle, nsleaderboardSetId);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithLeaderboardSetID_XHandle, nsleaderboardSetId);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsleaderboardSetId);
			return ret!;
		}
		/// <summary>An instance of the GameKit.IGKGameCenterControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the GameKit.IGKGameCenterControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameCenterControllerDelegate Delegate {
			get {
				return (WeakDelegate as IGKGameCenterControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'LeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? LeaderboardCategory {
			[Export ("leaderboardCategory", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeaderboardCategoryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeaderboardCategoryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLeaderboardCategory:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLeaderboardCategory_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLeaderboardCategory_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use '.ctor (GKLeaderboard, GKLeaderboardPlayerScope)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use '.ctor (GKLeaderboard, GKLeaderboardPlayerScope)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use '.ctor (GKLeaderboard, GKLeaderboardPlayerScope)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use '.ctor (GKLeaderboard, GKLeaderboardPlayerScope)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? LeaderboardIdentifier {
			[Export ("leaderboardIdentifier", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeaderboardIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeaderboardIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLeaderboardIdentifier:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLeaderboardIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLeaderboardIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[ObsoletedOSPlatform ("macos10.10", "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual GKLeaderboardTimeScope LeaderboardTimeScope {
			[Export ("leaderboardTimeScope", ArgumentSemantic.Assign)]
			get {
				GKLeaderboardTimeScope ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKLeaderboardTimeScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLeaderboardTimeScopeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKLeaderboardTimeScope) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selLeaderboardTimeScopeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLeaderboardTimeScope:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLeaderboardTimeScope_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetLeaderboardTimeScope_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use '.ctor (GKGameCenterViewControllerState)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use '.ctor (GKGameCenterViewControllerState)' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use '.ctor (GKGameCenterViewControllerState)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use '.ctor (GKGameCenterViewControllerState)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKGameCenterViewControllerState ViewState {
			[Export ("viewState", ArgumentSemantic.Assign)]
			get {
				GKGameCenterViewControllerState ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKGameCenterViewControllerState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKGameCenterViewControllerState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selViewStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setViewState:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetViewState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("gameCenterDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGameCenterDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGameCenterDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setGameCenterDelegate:", ArgumentSemantic.Weak)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGameCenterDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGameCenterDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_GKGameCenterControllerDelegate); }
		}
		internal virtual _GKGameCenterControllerDelegate CreateInternalEventDelegateType ()
		{
			return (_GKGameCenterControllerDelegate)(new _GKGameCenterControllerDelegate());
		}
		internal _GKGameCenterControllerDelegate EnsureGKGameCenterControllerDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _GKGameCenterControllerDelegate;
			if (del is null){
				del = (_GKGameCenterControllerDelegate)CreateInternalEventDelegateType ();
				Delegate = (IGKGameCenterControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _GKGameCenterControllerDelegate : NSObject, IGKGameCenterControllerDelegate { 
			public _GKGameCenterControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_GKGameCenterControllerDelegate))]
			static _GKGameCenterControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler? finished;
			[Export ("gameCenterViewControllerDidFinish:")]
			public void Finished (GameKit.GKGameCenterViewController controller)
			{
				var handler = finished;
				if (handler is not null){
					handler (controller, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler Finished {
			add { EnsureGKGameCenterControllerDelegate ()!.finished += value; }
			remove { EnsureGKGameCenterControllerDelegate ()!.finished -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GKGameCenterViewController */
}
