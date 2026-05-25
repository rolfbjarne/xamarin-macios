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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameKit {
	[Register("GKScore", true)]
	[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
	[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
	[ObsoletedOSPlatform ("macos11.0", "Use 'GKLeaderboardEntry' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'GKLeaderboardEntry' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKScore : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKScore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKScore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKScore () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public GKScore (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected GKScore (NSObjectFlag t) : base (t)
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
		protected internal GKScore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithLeaderboardIdentifier:player:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKScore (string identifier, GKPlayer player)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithLeaderboardIdentifier:player:"), nsidentifier, player__handle__), "initWithLeaderboardIdentifier:player:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithLeaderboardIdentifier:player:"), nsidentifier, player__handle__), "initWithLeaderboardIdentifier:player:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("initWithLeaderboardIdentifier:forPlayer:")]
		[ObsoletedOSPlatform ("ios8.0", "Use the overload that takes a 'GKPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes a 'GKPlayer' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKScore (string identifier, string playerID)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (playerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerID));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsplayerID = CFString.CreateNative (playerID);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithLeaderboardIdentifier:forPlayer:"), nsidentifier, nsplayerID), "initWithLeaderboardIdentifier:forPlayer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithLeaderboardIdentifier:forPlayer:"), nsidentifier, nsplayerID), "initWithLeaderboardIdentifier:forPlayer:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsplayerID);
		}
		/// <summary>Create a new <see cref="T:GameKit.GKScore" /> for the specified leaderboard.</summary><param name="categoryOrIdentifier">The identifier for the leaderboard the score is sent to.</param>
		[Export ("initWithLeaderboardIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKScore (string categoryOrIdentifier)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (categoryOrIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (categoryOrIdentifier));
			var nscategoryOrIdentifier = CFString.CreateNative (categoryOrIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithLeaderboardIdentifier:"), nscategoryOrIdentifier), "initWithLeaderboardIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithLeaderboardIdentifier:"), nscategoryOrIdentifier), "initWithLeaderboardIdentifier:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscategoryOrIdentifier);
		}
		[Export ("challengeComposeControllerWithPlayers:message:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ...)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ...)' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::UIKit.UIViewController? ChallengeComposeController (string[]? playerIDs, string? message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKChallengeComposeHandler))]GKChallengeComposeHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_playerIDs = NSArray.FromNullableStrings (playerIDs);
			var nsmessage = CFString.CreateNative (message);
			using var block_completionHandler = Trampolines.SDGKChallengeComposeHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::UIKit.UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("challengeComposeControllerWithPlayers:message:completionHandler:"), nsa_playerIDs.GetHandle (), nsmessage, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("challengeComposeControllerWithPlayers:message:completionHandler:"), nsa_playerIDs.GetHandle (), nsmessage, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		[Export ("challengeComposeControllerWithMessage:players:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::UIKit.UIViewController ChallengeComposeController (string? message, GKPlayer[]? players, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKChallengeComposeHandler))]GKChallengeComposeHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nsmessage = CFString.CreateNative (message);
			using var nsa_players = players is null ? null : NSArray.FromNSObjects (players);
			using var block_completionHandler = Trampolines.SDGKChallengeComposeHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::UIKit.UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completionHandler:"), nsmessage, nsa_players.GetHandle (), (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completionHandler:"), nsmessage, nsa_players.GetHandle (), (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		/// <param name="message">An editable message to display to the other players. May be .</param>
		/// <param name="players">The players to challenge.</param>
		/// <summary>Provides a view controller that can be used to send a challenge, with a message, to other players.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous ChallengeComposeController operation.   The value of the TResult parameter is of type <c>Action&lt;GameKit.GKChallengeComposeResult&gt;</c>.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The ChallengeComposeControllerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync (string? message, GKPlayer[]? players)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeResult> ();
			ChallengeComposeController(message, players, (composeController_, issuedChallenge_, sentPlayerIDs_) => {
				tcs.SetResult (new GKChallengeComposeResult (composeController_!, issuedChallenge_!, sentPlayerIDs_!));
			});
			return tcs.Task;
		}
		/// <param name="message">An editable message to display to the other players. May be <see langword="null" />.</param>
		/// <param name="players">The players to challenge.</param>
		/// <param name="result">The view controller that displays the result of the challenge. May be <see langword="null" />.</param>
		/// <summary>Asynchronously provides a view controller that can be used to send a challenge, with a message, to other players, returning a task that provides the challenge result.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync (string? message, GKPlayer[]? players, out global::UIKit.UIViewController result)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeResult> ();
			result = ChallengeComposeController(message, players, (composeController_, issuedChallenge_, sentPlayerIDs_) => {
				tcs.SetResult (new GKChallengeComposeResult (composeController_!, issuedChallenge_!, sentPlayerIDs_!));
			})!;
			return tcs.Task;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("issueChallengeToPlayers:message:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ... )' and present the view controller instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ... )' and present the view controller instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ... )' and present the view controller instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IssueChallengeToPlayers (string[]? playerIDs, string? message)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_playerIDs = NSArray.FromNullableStrings (playerIDs);
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("issueChallengeToPlayers:message:"), nsa_playerIDs.GetHandle (), nsmessage);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("issueChallengeToPlayers:message:"), nsa_playerIDs.GetHandle (), nsmessage);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("reportLeaderboardScores:withEligibleChallenges:withCompletionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReportLeaderboardScores (GKLeaderboardScore[] scores, GKChallenge[] eligibleChallenges, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (scores is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scores));
			if (eligibleChallenges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eligibleChallenges));
			using var nsa_scores = NSArray.FromNSObjects (scores);
			using var nsa_eligibleChallenges = NSArray.FromNSObjects (eligibleChallenges);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reportLeaderboardScores:withEligibleChallenges:withCompletionHandler:"), nsa_scores.Handle, nsa_eligibleChallenges.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ReportLeaderboardScoresAsync (GKLeaderboardScore[] scores, GKChallenge[] eligibleChallenges)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportLeaderboardScores(scores, eligibleChallenges, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("reportScoreWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'ReportScores' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'ReportScores' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ReportScores' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReportScore ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? errorHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_errorHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (errorHandler);
			BlockLiteral *block_ptr_errorHandler = null;
			if (errorHandler is not null)
				block_ptr_errorHandler = &block_errorHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("reportScoreWithCompletionHandler:"), (IntPtr) block_ptr_errorHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("reportScoreWithCompletionHandler:"), (IntPtr) block_ptr_errorHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Deprecated.</summary>
		/// <returns>A task that represents the asynchronous ReportScore operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'ReportScores' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'ReportScores' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ReportScores' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReportScoreAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportScore((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("reportScores:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReportScores (GKScore[] scores, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (scores is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scores));
			using var nsa_scores = NSArray.FromNSObjects (scores);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reportScores:withCompletionHandler:"), nsa_scores.Handle, (IntPtr) block_ptr_completionHandler);
		}
		/// <param name="scores">Scores to report back to Game Center.</param>
		/// <summary>Reports the provided scores to the Game Center.</summary>
		/// <returns>A task that represents the asynchronous ReportScores operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ReportScoresAsync (GKScore[] scores)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportScores(scores, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("reportScores:withEligibleChallenges:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReportScores (GKScore[] scores, GKChallenge[] challenges, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (scores is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (scores));
			if (challenges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (challenges));
			using var nsa_scores = NSArray.FromNSObjects (scores);
			using var nsa_challenges = NSArray.FromNSObjects (challenges);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reportScores:withEligibleChallenges:withCompletionHandler:"), nsa_scores.Handle, nsa_challenges.Handle, (IntPtr) block_ptr_completionHandler);
		}
		/// <param name="scores">To be added.</param>
		/// <param name="challenges">To be added.</param>
		/// <summary>Asynchronously reports the provided scores to the Game Center</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ReportScoresAsync (GKScore[] scores, GKChallenge[] challenges)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportScores(scores, challenges, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use 'LeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'LeaderboardIdentifier' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'LeaderboardIdentifier' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? Category {
			[Export ("category", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("category")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("category")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCategory:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCategory:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setCategory:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong Context {
			[Export ("context")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("context"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("context"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContext:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setContext:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, Selector.GetHandle ("setContext:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate Date {
			[Export ("date", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("date")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("date")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? FormattedValue {
			[Export ("formattedValue", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("formattedValue")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("formattedValue")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string? LeaderboardIdentifier {
			[Export ("leaderboardIdentifier", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("leaderboardIdentifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("leaderboardIdentifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLeaderboardIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLeaderboardIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setLeaderboardIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("tvos14.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GKLeaderboardEntry' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GKLeaderboardEntry' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual GKPlayer? Player {
			[Export ("player", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				GKPlayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("player")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("player")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Rank {
			[Export ("rank", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rank"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rank"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldSetDefaultLeaderboard {
			[Export ("shouldSetDefaultLeaderboard")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldSetDefaultLeaderboard"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shouldSetDefaultLeaderboard"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldSetDefaultLeaderboard:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldSetDefaultLeaderboard:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShouldSetDefaultLeaderboard:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long Value {
			[Export ("value")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("value"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setValue:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setValue:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (&__objc_super__, Selector.GetHandle ("setValue:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class GKScore */
	//
	// Async result classes
	//
}
