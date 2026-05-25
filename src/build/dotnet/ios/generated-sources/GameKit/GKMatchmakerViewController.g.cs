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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameKit {
	[Register("GKMatchmakerViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKMatchmakerViewController : global::UIKit.UINavigationController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKMatchmakerViewController");
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
		public GKMatchmakerViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected GKMatchmakerViewController (NSObjectFlag t) : base (t)
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
		protected internal GKMatchmakerViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithMatchRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKMatchmakerViewController (GKMatchRequest request)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithMatchRequest:"), request__handle__), "initWithMatchRequest:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMatchRequest:"), request__handle__), "initWithMatchRequest:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[Export ("initWithInvite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKMatchmakerViewController (GKInvite invite)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var invite__handle__ = invite!.GetNonNullHandle (nameof (invite));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithInvite:"), invite__handle__), "initWithInvite:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithInvite:"), invite__handle__), "initWithInvite:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (invite);
		}
		[Export ("addPlayersToMatch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddPlayersToMatch (GKMatch match)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var match__handle__ = match!.GetNonNullHandle (nameof (match));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addPlayersToMatch:"), match__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addPlayersToMatch:"), match__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (match);
		}
		[Export ("setHostedPlayer:connected:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios8.0", "Use 'SetHostedPlayerConnected (GKPlayer,bool)' instead.")]
		[ObsoletedOSPlatform ("macos10.10", "Use 'SetHostedPlayerConnected (GKPlayer,bool)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetHostedPlayerConnected (GKPlayer,bool)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHostedPlayerConnected (string playerID, bool connected)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (playerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerID));
			var nsplayerID = CFString.CreateNative (playerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setHostedPlayer:connected:"), nsplayerID, connected ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setHostedPlayer:connected:"), nsplayerID, connected ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsplayerID);
		}
		[Export ("setHostedPlayer:didConnect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHostedPlayerConnected (GKPlayer playerID, bool connected)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var playerID__handle__ = playerID!.GetNonNullHandle (nameof (playerID));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("setHostedPlayer:didConnect:"), playerID__handle__, connected ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("setHostedPlayer:didConnect:"), playerID__handle__, connected ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (playerID);
		}
		[Export ("setHostedPlayerReady:")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios5.0", "Use 'SetHostedPlayerConnected' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SetHostedPlayerConnected' instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHostedPlayerReady (string playerID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (playerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (playerID));
			var nsplayerID = CFString.CreateNative (playerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setHostedPlayerReady:"), nsplayerID);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setHostedPlayerReady:"), nsplayerID);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsplayerID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool CanStartWithMinimumPlayers {
			[Export ("canStartWithMinimumPlayers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canStartWithMinimumPlayers"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("canStartWithMinimumPlayers"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanStartWithMinimumPlayers:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCanStartWithMinimumPlayers:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setCanStartWithMinimumPlayers:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? DefaultInvitationMessage {
			[Export ("defaultInvitationMessage", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("defaultInvitationMessage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("defaultInvitationMessage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultInvitationMessage:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDefaultInvitationMessage:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDefaultInvitationMessage:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hosted {
			[Export ("isHosted")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHosted"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isHosted"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHosted:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHosted:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setHosted:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKMatchRequest MatchRequest {
			[Export ("matchRequest", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				GKMatchRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKMatchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("matchRequest")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKMatchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("matchRequest")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKMatchmakerViewControllerDelegate? MatchmakerDelegate {
			get {
				return (WeakMatchmakerDelegate as IGKMatchmakerViewControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakMatchmakerDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual GKMatchmakingMode MatchmakingMode {
			[Export ("matchmakingMode", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				GKMatchmakingMode ret;
				if (IsDirectBinding) {
					ret = (GameKit.GKMatchmakingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("matchmakingMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GameKit.GKMatchmakingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("matchmakingMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMatchmakingMode:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMatchmakingMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setMatchmakingMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakMatchmakerDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakMatchmakerDelegate {
			[Export ("matchmakerDelegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("matchmakerDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("matchmakerDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakMatchmakerDelegate_var = ret;
				return ret!;
			}
			[Export ("setMatchmakerDelegate:", ArgumentSemantic.Assign)]
			set {
				UIApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakMatchmakerDelegate_var, value, GetInternalEventMatchmakerDelegateType);
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMatchmakerDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setMatchmakerDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakMatchmakerDelegate_var = value;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventMatchmakerDelegateType
		{
			get { return typeof (_GKMatchmakerViewControllerDelegate); }
		}
		internal virtual _GKMatchmakerViewControllerDelegate CreateInternalEventMatchmakerDelegateType ()
		{
			return (_GKMatchmakerViewControllerDelegate)(new _GKMatchmakerViewControllerDelegate());
		}
		internal _GKMatchmakerViewControllerDelegate EnsureGKMatchmakerViewControllerDelegate ()
		{
			if (WeakMatchmakerDelegate is not null)
				UIApplication.EnsureEventAndDelegateAreNotMismatched (WeakMatchmakerDelegate, GetInternalEventMatchmakerDelegateType);
			var del = MatchmakerDelegate as _GKMatchmakerViewControllerDelegate;
			if (del is null){
				del = (_GKMatchmakerViewControllerDelegate)CreateInternalEventMatchmakerDelegateType ();
				MatchmakerDelegate = (IGKMatchmakerViewControllerDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _GKMatchmakerViewControllerDelegate : NSObject, IGKMatchmakerViewControllerDelegate { 
			public _GKMatchmakerViewControllerDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_GKMatchmakerViewControllerDelegate))]
			static _GKMatchmakerViewControllerDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<GKErrorEventArgs>? didFailWithError;
			[Export ("matchmakerViewController:didFailWithError:")]
			public void DidFailWithError (GameKit.GKMatchmakerViewController viewController, NSError error)
			{
				var handler = didFailWithError;
				if (handler is not null){
					var args = new GKErrorEventArgs (error);
					handler (viewController, args);
				}
			}
			internal EventHandler<GKMatchmakingPlayersEventArgs>? didFindHostedPlayers;
			[Export ("matchmakerViewController:didFindHostedPlayers:")]
			public void DidFindHostedPlayers (GameKit.GKMatchmakerViewController viewController, GameKit.GKPlayer[] playerIDs)
			{
				var handler = didFindHostedPlayers;
				if (handler is not null){
					var args = new GKMatchmakingPlayersEventArgs (playerIDs);
					handler (viewController, args);
				}
			}
			internal EventHandler<GKMatchEventArgs>? didFindMatch;
			[Export ("matchmakerViewController:didFindMatch:")]
			public void DidFindMatch (GameKit.GKMatchmakerViewController viewController, GameKit.GKMatch match)
			{
				var handler = didFindMatch;
				if (handler is not null){
					var args = new GKMatchEventArgs (match);
					handler (viewController, args);
				}
			}
			internal EventHandler<GKPlayersEventArgs>? didFindPlayers;
			[Export ("matchmakerViewController:didFindPlayers:")]
			public void DidFindPlayers (GameKit.GKMatchmakerViewController viewController, String[] playerIDs)
			{
				var handler = didFindPlayers;
				if (handler is not null){
					var args = new GKPlayersEventArgs (playerIDs);
					handler (viewController, args);
				}
			}
			internal EventHandler<GKMatchmakingPlayerEventArgs>? hostedPlayerDidAccept;
			[Export ("matchmakerViewController:hostedPlayerDidAccept:")]
			public void HostedPlayerDidAccept (GameKit.GKMatchmakerViewController viewController, GameKit.GKPlayer playerID)
			{
				var handler = hostedPlayerDidAccept;
				if (handler is not null){
					var args = new GKMatchmakingPlayerEventArgs (playerID);
					handler (viewController, args);
				}
			}
			internal EventHandler<GKPlayerEventArgs>? receivedAcceptFromHostedPlayer;
			[Export ("matchmakerViewController:didReceiveAcceptFromHostedPlayer:")]
			public void ReceivedAcceptFromHostedPlayer (GameKit.GKMatchmakerViewController viewController, string playerID)
			{
				var handler = receivedAcceptFromHostedPlayer;
				if (handler is not null){
					var args = new GKPlayerEventArgs (playerID);
					handler (viewController, args);
				}
			}
			internal EventHandler? wasCancelled;
			[Export ("matchmakerViewControllerWasCancelled:")]
			public void WasCancelled (GameKit.GKMatchmakerViewController viewController)
			{
				var handler = wasCancelled;
				if (handler is not null){
					handler (viewController, EventArgs.Empty);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKErrorEventArgs> DidFailWithError {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.didFailWithError += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.didFailWithError -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKMatchmakingPlayersEventArgs> DidFindHostedPlayers {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.didFindHostedPlayers += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.didFindHostedPlayers -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKMatchEventArgs> DidFindMatch {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.didFindMatch += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.didFindMatch -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKPlayersEventArgs> DidFindPlayers {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.didFindPlayers += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.didFindPlayers -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKMatchmakingPlayerEventArgs> HostedPlayerDidAccept {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.hostedPlayerDidAccept += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.hostedPlayerDidAccept -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<GKPlayerEventArgs> ReceivedAcceptFromHostedPlayer {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.receivedAcceptFromHostedPlayer += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.receivedAcceptFromHostedPlayer -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakMatchmakerDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler WasCancelled {
			add { EnsureGKMatchmakerViewControllerDelegate ()!.wasCancelled += value; }
			remove { EnsureGKMatchmakerViewControllerDelegate ()!.wasCancelled -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakMatchmakerDelegate_var = null;
			}
		}
	} /* class GKMatchmakerViewController */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class GKMatchEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="GKMatchEventArgs" /> with the specified event data.</summary>
		/// <param name="match">The value for the <see cref="Match" /> property.</param>
		public GKMatchEventArgs (GameKit.GKMatch match)
		{
			this.Match = match;
		}
		public GameKit.GKMatch Match { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class GKMatchmakingPlayerEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="GKMatchmakingPlayerEventArgs" /> with the specified event data.</summary>
		/// <param name="playerID">The value for the <see cref="PlayerID" /> property.</param>
		public GKMatchmakingPlayerEventArgs (GameKit.GKPlayer playerID)
		{
			this.PlayerID = playerID;
		}
		public GameKit.GKPlayer PlayerID { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class GKMatchmakingPlayersEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="GKMatchmakingPlayersEventArgs" /> with the specified event data.</summary>
		/// <param name="playerIDs">The value for the <see cref="PlayerIDs" /> property.</param>
		public GKMatchmakingPlayersEventArgs (GameKit.GKPlayer[] playerIDs)
		{
			this.PlayerIDs = playerIDs;
		}
		public GameKit.GKPlayer[] PlayerIDs { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class GKPlayerEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="GKPlayerEventArgs" /> with the specified event data.</summary>
		/// <param name="playerID">The value for the <see cref="PlayerID" /> property.</param>
		public GKPlayerEventArgs (string playerID)
		{
			this.PlayerID = playerID;
		}
		public string PlayerID { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class GKPlayersEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="GKPlayersEventArgs" /> with the specified event data.</summary>
		/// <param name="playerIDs">The value for the <see cref="PlayerIDs" /> property.</param>
		public GKPlayersEventArgs (String[] playerIDs)
		{
			this.PlayerIDs = playerIDs;
		}
		public String[] PlayerIDs { get; set; }
	}
}
