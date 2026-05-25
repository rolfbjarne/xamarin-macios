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
	/// <summary>Provides the functionality necessary to discover and connect to nearby iPhones and iPads over Bluetooth.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKSession_Class/index.html">Apple documentation for <c>GKSession</c></related>
	[Register("GKSession", true)]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'MultipeerConnectivity.MCSession' instead.")]
	[ObsoletedOSPlatform ("macos10.10", "Use 'MultipeerConnectivity.MCSession' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MultipeerConnectivity.MCSession' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class GKSession : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcceptConnectionFromPeer_Error_X = "acceptConnectionFromPeer:error:";
		static readonly NativeHandle selAcceptConnectionFromPeer_Error_XHandle = Selector.GetHandle ("acceptConnectionFromPeer:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelConnectToPeer_X = "cancelConnectToPeer:";
		static readonly NativeHandle selCancelConnectToPeer_XHandle = Selector.GetHandle ("cancelConnectToPeer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectToPeer_WithTimeout_X = "connectToPeer:withTimeout:";
		static readonly NativeHandle selConnectToPeer_WithTimeout_XHandle = Selector.GetHandle ("connectToPeer:withTimeout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDenyConnectionFromPeer_X = "denyConnectionFromPeer:";
		static readonly NativeHandle selDenyConnectionFromPeer_XHandle = Selector.GetHandle ("denyConnectionFromPeer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectFromAllPeersX = "disconnectFromAllPeers";
		static readonly NativeHandle selDisconnectFromAllPeersXHandle = Selector.GetHandle ("disconnectFromAllPeers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectPeerFromAllPeers_X = "disconnectPeerFromAllPeers:";
		static readonly NativeHandle selDisconnectPeerFromAllPeers_XHandle = Selector.GetHandle ("disconnectPeerFromAllPeers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectTimeoutX = "disconnectTimeout";
		static readonly NativeHandle selDisconnectTimeoutXHandle = Selector.GetHandle ("disconnectTimeout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameX = "displayName";
		static readonly NativeHandle selDisplayNameXHandle = Selector.GetHandle ("displayName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameForPeer_X = "displayNameForPeer:";
		static readonly NativeHandle selDisplayNameForPeer_XHandle = Selector.GetHandle ("displayNameForPeer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSessionID_DisplayName_SessionMode_X = "initWithSessionID:displayName:sessionMode:";
		static readonly NativeHandle selInitWithSessionID_DisplayName_SessionMode_XHandle = Selector.GetHandle ("initWithSessionID:displayName:sessionMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAvailableX = "isAvailable";
		static readonly NativeHandle selIsAvailableXHandle = Selector.GetHandle ("isAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPeerIDX = "peerID";
		static readonly NativeHandle selPeerIDXHandle = Selector.GetHandle ("peerID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPeersWithConnectionState_X = "peersWithConnectionState:";
		static readonly NativeHandle selPeersWithConnectionState_XHandle = Selector.GetHandle ("peersWithConnectionState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendData_ToPeers_WithDataMode_Error_X = "sendData:toPeers:withDataMode:error:";
		static readonly NativeHandle selSendData_ToPeers_WithDataMode_Error_XHandle = Selector.GetHandle ("sendData:toPeers:withDataMode:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendDataToAllPeers_WithDataMode_Error_X = "sendDataToAllPeers:withDataMode:error:";
		static readonly NativeHandle selSendDataToAllPeers_WithDataMode_Error_XHandle = Selector.GetHandle ("sendDataToAllPeers:withDataMode:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSessionIDX = "sessionID";
		static readonly NativeHandle selSessionIDXHandle = Selector.GetHandle ("sessionID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSessionModeX = "sessionMode";
		static readonly NativeHandle selSessionModeXHandle = Selector.GetHandle ("sessionMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAvailable_X = "setAvailable:";
		static readonly NativeHandle selSetAvailable_XHandle = Selector.GetHandle ("setAvailable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDataReceiveHandler_WithContext_X = "setDataReceiveHandler:withContext:";
		static readonly NativeHandle selSetDataReceiveHandler_WithContext_XHandle = Selector.GetHandle ("setDataReceiveHandler:withContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisconnectTimeout_X = "setDisconnectTimeout:";
		static readonly NativeHandle selSetDisconnectTimeout_XHandle = Selector.GetHandle ("setDisconnectTimeout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKSession");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKSession" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKSession () : base (NSObjectFlag.Empty)
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
		protected GKSession (NSObjectFlag t) : base (t)
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
		protected internal GKSession (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSessionID:displayName:sessionMode:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKSession (string? sessionID, string? displayName, GKSessionMode mode)
			: base (NSObjectFlag.Empty)
		{
			var nssessionID = CFString.CreateNative (sessionID);
			var nsdisplayName = CFString.CreateNative (displayName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_int (this.Handle, selInitWithSessionID_DisplayName_SessionMode_XHandle, nssessionID, nsdisplayName, (int)mode), "initWithSessionID:displayName:sessionMode:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_int (&__objc_super__, selInitWithSessionID_DisplayName_SessionMode_XHandle, nssessionID, nsdisplayName, (int)mode), "initWithSessionID:displayName:sessionMode:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssessionID);
			CFString.ReleaseNative (nsdisplayName);
		}
		[Export ("acceptConnectionFromPeer:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AcceptConnection (string peerID, out NSError error)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			NativeHandle errorValue = IntPtr.Zero;
			var nspeerID = CFString.CreateNative (peerID);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selAcceptConnectionFromPeer_Error_XHandle, nspeerID, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selAcceptConnectionFromPeer_Error_XHandle, nspeerID, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("cancelConnectToPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelConnect (string peerID)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selCancelConnectToPeer_XHandle, nspeerID);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selCancelConnectToPeer_XHandle, nspeerID);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
		}
		[Export ("connectToPeer:withTimeout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Connect (string peerID, double timeout)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (this.Handle, selConnectToPeer_WithTimeout_XHandle, nspeerID, timeout);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_Double (&__objc_super__, selConnectToPeer_WithTimeout_XHandle, nspeerID, timeout);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
		}
		[Export ("denyConnectionFromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DenyConnection (string peerID)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDenyConnectionFromPeer_XHandle, nspeerID);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDenyConnectionFromPeer_XHandle, nspeerID);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
		}
		[Export ("disconnectFromAllPeers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectFromAllPeers ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectFromAllPeersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisconnectFromAllPeersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("disconnectPeerFromAllPeers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectPeerFromAllPeers (string peerID)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDisconnectPeerFromAllPeers_XHandle, nspeerID);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisconnectPeerFromAllPeers_XHandle, nspeerID);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
		}
		[Export ("displayNameForPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisplayNameForPeer (string peerID)
		{
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDisplayNameForPeer_XHandle, nspeerID), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisplayNameForPeer_XHandle, nspeerID), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspeerID);
			return ret!;
		}
		[Export ("peersWithConnectionState:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PeersWithConnectionState (GKPeerConnectionState state)
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selPeersWithConnectionState_XHandle, (int)state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selPeersWithConnectionState_XHandle, (int)state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sendData:toPeers:withDataMode:error:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SendData (NSData data, string[] peers, GKSendDataMode mode, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (peers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peers));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_peers = NSArray.FromStrings (peers);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_int_ref_NativeHandle (this.Handle, selSendData_ToPeers_WithDataMode_Error_XHandle, data__handle__, nsa_peers.Handle, (int)mode, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_int_ref_NativeHandle (&__objc_super__, selSendData_ToPeers_WithDataMode_Error_XHandle, data__handle__, nsa_peers.Handle, (int)mode, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("sendDataToAllPeers:withDataMode:error:")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SendDataToAllPeers (NSData data, GKSendDataMode mode, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_int_ref_NativeHandle (this.Handle, selSendDataToAllPeers_WithDataMode_Error_XHandle, data__handle__, (int)mode, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_int_ref_NativeHandle (&__objc_super__, selSendDataToAllPeers_WithDataMode_Error_XHandle, data__handle__, (int)mode, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("setDataReceiveHandler:withContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetDataReceiveHandler (NSObject obj, nint context)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetDataReceiveHandler_WithContext_XHandle, obj__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetDataReceiveHandler_WithContext_XHandle, obj__handle__, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Available {
			[Export ("isAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAvailableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAvailableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAvailable:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAvailable_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAvailable_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the GameKit.IGKSessionDelegate model class which acts as the class delegate.</summary><value>The instance of the GameKit.IGKSessionDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKSessionDelegate Delegate {
			get {
				return (WeakDelegate as IGKSessionDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DisconnectTimeout {
			[Export ("disconnectTimeout")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDisconnectTimeoutXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDisconnectTimeoutXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDisconnectTimeout:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDisconnectTimeout_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDisconnectTimeout_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisplayName {
			[Export ("displayName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDisplayNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDisplayNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PeerID {
			[Export ("peerID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPeerIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPeerIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SessionID {
			[Export ("sessionID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSessionIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSessionIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("macos10.10")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual GKSessionMode SessionMode {
			[Export ("sessionMode")]
			get {
				GKSessionMode ret;
				if (IsDirectBinding) {
					ret = (GKSessionMode) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSessionModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GKSessionMode) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selSessionModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GKSession */
}
