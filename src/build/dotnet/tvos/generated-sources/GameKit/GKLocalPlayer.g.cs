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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
	public unsafe partial class GKLocalPlayer : GKPlayer {
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
		public GKLocalPlayer (NSCoder coder) : base (NSObjectFlag.Empty)
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

		[Export ("fetchItemsForIdentityVerificationSignature:")]
		[SupportedOSPlatform ("tvos13.4")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchItemsForIdentityVerificationSignature ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler))]GKFetchItemsForIdentityVerificationSignatureCompletionHandler? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDGKFetchItemsForIdentityVerificationSignatureCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fetchItemsForIdentityVerificationSignature:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fetchItemsForIdentityVerificationSignature:"), (IntPtr) block_ptr_completionHandler);
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
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDGKIdentityVerificationSignatureHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("generateIdentityVerificationSignatureWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("generateIdentityVerificationSignatureWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		[Export ("loadChallengableFriendsWithCompletionHandler:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadChallengeableFriends ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V57))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity2V57.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadChallengableFriendsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadChallengableFriendsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		public unsafe virtual void LoadDefaultLeaderboardIdentifier ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V50))]global::System.Action<string, NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity2V50.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadDefaultLeaderboardIdentifierWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadDefaultLeaderboardIdentifierWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		public unsafe virtual void LoadFriendPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V57))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity2V57.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadFriendPlayersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFriendPlayersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		[Export ("loadFriendsAuthorizationStatus:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFriendsAuthorizationStatus ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V63))]global::System.Action<GKFriendsAuthorizationStatus, NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V63.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadFriendsAuthorizationStatus:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFriendsAuthorizationStatus:"), (IntPtr) block_ptr_completionHandler);
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
		public unsafe virtual void LoadFriendsList ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V57))]global::System.Action<GKPlayer[], NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V57.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadFriends:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFriends:"), (IntPtr) block_ptr_completionHandler);
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
		public unsafe virtual void LoadFriendsList (string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V57))]global::System.Action<GKPlayer[], NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_completionHandler = Trampolines.SDActionArity2V57.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadFriendsWithIdentifiers:completionHandler:"), nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadFriendsWithIdentifiers:completionHandler:"), nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
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
		public unsafe virtual void LoadRecentPlayers ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V57))]global::System.Action<GKPlayer[], NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var block_completionHandler = Trampolines.SDActionArity2V57.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadRecentPlayersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("loadRecentPlayersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		[Export ("registerListener:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterListener (IGKLocalPlayerListener listener)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("registerListener:"), listener__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("registerListener:"), listener__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (listener);
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
		public unsafe virtual void SetDefaultLeaderboardIdentifier (string leaderboardIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V10))]global::System.Action<NSError>? completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (leaderboardIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leaderboardIdentifier));
			var nsleaderboardIdentifier = CFString.CreateNative (leaderboardIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity1V10.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setDefaultLeaderboardIdentifier:completionHandler:"), nsleaderboardIdentifier, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setDefaultLeaderboardIdentifier:completionHandler:"), nsleaderboardIdentifier, (IntPtr) block_ptr_completionHandler);
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
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unregisterAllListeners"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("unregisterAllListeners"));
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
			global::UIKit.UIApplication.EnsureUIThread ();
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unregisterListener:"), listener__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unregisterListener:"), listener__handle__);
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
		public unsafe virtual global::System.Action<global::UIKit.UIViewController, NSError>? AuthenticateHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity2V64))]
			[Export ("authenticateHandler", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("authenticateHandler"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("authenticateHandler"));
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity2V64.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V64))]
			[Export ("setAuthenticateHandler:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var block_value = Trampolines.SDActionArity2V64.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAuthenticateHandler:"), (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAuthenticateHandler:"), (IntPtr) block_ptr_value);
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
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAuthenticated"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isAuthenticated"));
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
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUnderage"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isUnderage"));
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
				global::UIKit.UIApplication.EnsureUIThread ();
				GKLocalPlayer? ret;
				ret =  Runtime.GetNSObject<GKLocalPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("local")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKLocalPlayer LocalPlayer {
			[Export ("localPlayer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				GKLocalPlayer? ret;
				ret =  Runtime.GetNSObject<GKLocalPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("localPlayer")), false)!;
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
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMultiplayerGamingRestricted"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isMultiplayerGamingRestricted"));
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
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPersonalizedCommunicationRestricted"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isPersonalizedCommunicationRestricted"));
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
