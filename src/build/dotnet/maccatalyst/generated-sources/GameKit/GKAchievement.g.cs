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
	[Register("GKAchievement", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKAchievement : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKAchievement");
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
		public GKAchievement (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected GKAchievement (NSObjectFlag t) : base (t)
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
		protected internal GKAchievement (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Default constructor that initializes a new instance of this class with no parameters.</summary><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKAchievement ()
			: this ((string) null!)
		{
		}
		[Export ("initWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKAchievement (string? identifier)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIdentifier:"), nsidentifier), "initWithIdentifier:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("initWithIdentifier:forPlayer:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'ctor (string identifier, GKPlayer player)' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'ctor (string identifier, GKPlayer player)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'ctor (string identifier, GKPlayer player)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKAchievement (string? identifier, string playerId)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (playerId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerId));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsplayerId = CFString.CreateNative (playerId);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithIdentifier:forPlayer:"), nsidentifier, nsplayerId), "initWithIdentifier:forPlayer:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIdentifier:forPlayer:"), nsidentifier, nsplayerId), "initWithIdentifier:forPlayer:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsplayerId);
		}
		[Export ("initWithIdentifier:player:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKAchievement (string? identifier, GKPlayer player)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithIdentifier:player:"), nsidentifier, player__handle__), "initWithIdentifier:player:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIdentifier:player:"), nsidentifier, player__handle__), "initWithIdentifier:player:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("challengeComposeControllerWithMessage:players:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::UIKit.UIViewController ChallengeComposeController (string? message, GKPlayer[] players, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKChallengeComposeHandler))]GKChallengeComposeHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (players is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (players));
			var nsmessage = CFString.CreateNative (message);
			using var nsa_players = NSArray.FromNSObjects (players);
			using var block_completionHandler = Trampolines.SDGKChallengeComposeHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::UIKit.UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completionHandler:"), nsmessage, nsa_players.Handle, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completionHandler:"), nsmessage, nsa_players.Handle, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		/// <summary>Provides a view controller that can be used to send a challenge, with a message, to other players.</summary>
		/// <param name="message">An editable message to display to the other players. May be <see langword="null" />.</param>
		/// <param name="players">The players to challenge.</param>
		/// <returns>
		///   <para>A task that represents the asynchronous ChallengeComposeController operation. The value of the TResult parameter is of type GameKit.GKChallengeComposeResult. Holds the return values from the asynchronous method.</para>
		/// </returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync (string? message, GKPlayer[] players)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeResult> ();
			ChallengeComposeController(message, players, (composeController_, issuedChallenge_, sentPlayerIDs_) => {
				tcs.SetResult (new GKChallengeComposeResult (composeController_!, issuedChallenge_!, sentPlayerIDs_!));
			});
			return tcs.Task;
		}
		/// <summary>Asynchronously provides a view controller that can be used to send a challenge, with a message, to other players, returning a task with the response result.</summary>
		/// <param name="message">An editable message to display to the other players. May be <see langword="null" />.</param>
		/// <param name="players">The players to challenge.</param>
		/// <param name="result">The view controller that displays the result of the challenge. May be <see langword="null" />.</param>
		/// <remarks>
		///   <para>The type of the <paramref name="result" /> out argument is <see cref="UIKit.UIViewController" /> on iOS, tvOS and Mac Catalyst and <see cref="T:AppKit.NSViewController" /> on macOS.</para>
		/// </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("macos14.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync (string? message, GKPlayer[] players, out global::UIKit.UIViewController result)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeResult> ();
			result = ChallengeComposeController(message, players, (composeController_, issuedChallenge_, sentPlayerIDs_) => {
				tcs.SetResult (new GKChallengeComposeResult (composeController_!, issuedChallenge_!, sentPlayerIDs_!));
			})!;
			return tcs.Task;
		}
		[Export ("challengeComposeControllerWithPlayers:message:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::UIKit.UIViewController? ChallengeComposeController (GKPlayer[]? playerIDs, string? message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKChallengeComposeHandler))]GKChallengeComposeHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_playerIDs = playerIDs is null ? null : NSArray.FromNSObjects (playerIDs);
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
		[Export ("challengeComposeControllerWithMessage:players:completion:")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual global::UIKit.UIViewController ChallengeComposeControllerWithMessage (string? message, GKPlayer[] players, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKChallengeComposeHandler2))]GKChallengeComposeHandler2? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (players is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (players));
			var nsmessage = CFString.CreateNative (message);
			using var nsa_players = NSArray.FromNSObjects (players);
			using var block_completionHandler = Trampolines.SDGKChallengeComposeHandler2.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::UIKit.UIViewController? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completion:"), nsmessage, nsa_players.Handle, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("challengeComposeControllerWithMessage:players:completion:"), nsmessage, nsa_players.Handle, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmessage);
			return ret!;
		}
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeControllerResult> ChallengeComposeControllerWithMessageAsync (string? message, GKPlayer[] players)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeControllerResult> ();
			ChallengeComposeControllerWithMessage(message, players, (composeController_, issuedChallenge_, sentPlayers_) => {
				tcs.SetResult (new GKChallengeComposeControllerResult (composeController_!, issuedChallenge_!, sentPlayers_!));
			});
			return tcs.Task;
		}
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKChallengeComposeControllerResult> ChallengeComposeControllerWithMessageAsync (string? message, GKPlayer[] players, out global::UIKit.UIViewController result)
		{
			var tcs = new TaskCompletionSource<GKChallengeComposeControllerResult> ();
			result = ChallengeComposeControllerWithMessage(message, players, (composeController_, issuedChallenge_, sentPlayers_) => {
				tcs.SetResult (new GKChallengeComposeControllerResult (composeController_!, issuedChallenge_!, sentPlayers_!));
			})!;
			return tcs.Task;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		[ObsoletedOSPlatform ("ios7.0", "Pass 'GKPlayers' to 'ChallengeComposeController(GKPlayer[] players, string message, ...)' and present the view controller instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Pass 'GKPlayers' to 'ChallengeComposeController(GKPlayer[] players, string message, ...)' and present the view controller instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Pass 'GKPlayers' to 'ChallengeComposeController(GKPlayer[] players, string message, ...)' and present the view controller instead.")]
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
		[Export ("loadAchievementsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadAchievements ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKCompletionHandler))]GKCompletionHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDGKCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("loadAchievementsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>Asynchronously loads the achievement progress.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous LoadAchievements operation.   The value of the TResult parameter is a GameKit.GKCompletionHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<GKAchievement[]> LoadAchievementsAsync ()
		{
			var tcs = new TaskCompletionSource<GKAchievement[]> ();
			LoadAchievements((achivements_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (achivements_!);
			});
			return tcs.Task;
		}
		[Export ("reportAchievementWithCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReportAchievement ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("reportAchievementWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("reportAchievementWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Deprecated.</summary>
		/// <returns>A task that represents the asynchronous ReportAchievement operation</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReportAchievementAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportAchievement((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("reportAchievements:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReportAchievements (GKAchievement[] achievements, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (achievements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievements));
			using var nsa_achievements = NSArray.FromNSObjects (achievements);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reportAchievements:withCompletionHandler:"), nsa_achievements.Handle, (IntPtr) block_ptr_completionHandler);
		}
		/// <param name="achievements">Achievements to report to Game Center.</param>
		/// <summary>Asynchronously reports the provided achievements and matching challenges to Game Center.</summary>
		/// <returns>A task that represents the asynchronous ReportAchievements operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ReportAchievementsAsync (GKAchievement[] achievements)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportAchievements(achievements, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("reportAchievements:withEligibleChallenges:withCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ReportAchievements (GKAchievement[] achievements, GKChallenge[] challenges, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (achievements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (achievements));
			if (challenges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (challenges));
			using var nsa_achievements = NSArray.FromNSObjects (achievements);
			using var nsa_challenges = NSArray.FromNSObjects (challenges);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("reportAchievements:withEligibleChallenges:withCompletionHandler:"), nsa_achievements.Handle, nsa_challenges.Handle, (IntPtr) block_ptr_completionHandler);
		}
		/// <param name="achievements">To be added.</param>
		/// <param name="challenges">To be added.</param>
		/// <summary>Asynchronously reports the provided achievements and challenges to Game Center.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ReportAchievementsAsync (GKAchievement[] achievements, GKChallenge[] challenges)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ReportAchievements(achievements, challenges, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("resetAchievementsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResetAchivements ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("resetAchievementsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		/// <summary>Asynchronously resets all achievements for the local player.</summary>
		/// <returns>A task that represents the asynchronous ResetAchivements operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task ResetAchivementsAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			ResetAchivements((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("selectChallengeablePlayerIDs:withCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectChallengeablePlayerIDs (string[]? playerIDs, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V82))]global::System.Action<string[], NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsa_playerIDs = NSArray.FromNullableStrings (playerIDs);
			using var block_completionHandler = Trampolines.SDActionArity2V82.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("selectChallengeablePlayerIDs:withCompletionHandler:"), nsa_playerIDs.GetHandle (), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("selectChallengeablePlayerIDs:withCompletionHandler:"), nsa_playerIDs.GetHandle (), (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="playerIDs">To be added.</param>
		/// <summary>Deprecated.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SelectChallengeablePlayerIDs operation.  The value of the TResult parameter is of type System.Action&lt;System.String[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<string[]> SelectChallengeablePlayerIDsAsync (string[]? playerIDs)
		{
			var tcs = new TaskCompletionSource<string[]> ();
			SelectChallengeablePlayerIDs(playerIDs, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("selectChallengeablePlayers:withCompletionHandler:")]
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SelectChallengeablePlayers (GKPlayer[] players, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V83))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (players is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (players));
			using var nsa_players = NSArray.FromNSObjects (players);
			using var block_completionHandler = Trampolines.SDActionArity2V83.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("selectChallengeablePlayers:withCompletionHandler:"), nsa_players.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("selectChallengeablePlayers:withCompletionHandler:"), nsa_players.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="players">To be added.</param>
		/// <summary>Asynchronously selects the players who can earn the achievement.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous SelectChallengeablePlayers operation.  The value of the TResult parameter is of type System.Action&lt;GameKit.GKPlayer[],Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The SelectChallengeablePlayersAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios26.0")]
		[ObsoletedOSPlatform ("macos26.0")]
		[ObsoletedOSPlatform ("tvos26.0")]
		[ObsoletedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<GKPlayer[]> SelectChallengeablePlayersAsync (GKPlayer[] players)
		{
			var tcs = new TaskCompletionSource<GKPlayer[]> ();
			SelectChallengeablePlayers(players, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <summary>Gets a value that tells whether the player completed the achievement.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Completed {
			[Export ("isCompleted")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCompleted"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isCompleted"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Deprecated.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHidden"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHidden"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifier")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIdentifier:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIdentifier:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setIdentifier:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate LastReportedDate {
			[Export ("lastReportedDate", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lastReportedDate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("lastReportedDate")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[NotImplemented ()]
			set {
				throw new NotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double PercentComplete {
			[Export ("percentComplete")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("percentComplete"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("percentComplete"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPercentComplete:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setPercentComplete:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, Selector.GetHandle ("setPercentComplete:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
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
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'Player' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'Player' instead.")]
		[SupportedOSPlatform ("ios")]
		public virtual string? PlayerID {
			[Export ("playerID", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("playerID")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("playerID")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsCompletionBanner {
			[Export ("showsCompletionBanner")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsCompletionBanner"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsCompletionBanner"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsCompletionBanner:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsCompletionBanner:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsCompletionBanner:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class GKAchievement */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKChallengeComposeControllerResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public global::UIKit.UIViewController ComposeController { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool IssuedChallenge { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public GKPlayer[] SentPlayers { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="composeController">Result value from an asynchronous operation.</param>
		/// <param name="issuedChallenge">Result value from an asynchronous operation.</param>
		/// <param name="sentPlayers">Result value from an asynchronous operation.</param>
		public GKChallengeComposeControllerResult (global::UIKit.UIViewController composeController, bool issuedChallenge, GKPlayer[] sentPlayers) {
			this.ComposeController = composeController;
			this.IssuedChallenge = issuedChallenge;
			this.SentPlayers = sentPlayers;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class GKChallengeComposeResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public global::UIKit.UIViewController ComposeController { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public bool IssuedChallenge { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public string[] SentPlayerIDs { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="composeController">Result value from an asynchronous operation.</param>
		/// <param name="issuedChallenge">Result value from an asynchronous operation.</param>
		/// <param name="sentPlayerIDs">Result value from an asynchronous operation.</param>
		public GKChallengeComposeResult (global::UIKit.UIViewController composeController, bool issuedChallenge, string[] sentPlayerIDs) {
			this.ComposeController = composeController;
			this.IssuedChallenge = issuedChallenge;
			this.SentPlayerIDs = sentPlayerIDs;
			Initialize ();
		}
	}
}
