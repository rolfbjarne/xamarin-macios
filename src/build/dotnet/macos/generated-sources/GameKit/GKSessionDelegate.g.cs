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
	#pragma warning disable CS1573
	/// <summary>Delegate for the GKSession class.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKSessionDelegate_Protocol/index.html">Apple documentation for <c>GKSessionDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[ObsoletedOSPlatform ("macos10.10", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "GKSessionDelegate", WrapperType = typeof (GKSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerChangedState", Selector = "session:peer:didChangeState:", ParameterType = new Type [] { typeof (GameKit.GKSession), typeof (string), typeof (GameKit.GKPeerConnectionState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerConnectionRequest", Selector = "session:didReceiveConnectionRequestFromPeer:", ParameterType = new Type [] { typeof (GameKit.GKSession), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PeerConnectionFailed", Selector = "session:connectionWithPeerFailed:withError:", ParameterType = new Type [] { typeof (GameKit.GKSession), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "session:didFailWithError:", ParameterType = new Type [] { typeof (GameKit.GKSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IGKSessionDelegate : INativeObject, IDisposable
	{
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:peer:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerChangedState (GKSession session, string peerID, GKPeerConnectionState state)
		{
			_PeerChangedState (this, session, peerID, state);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PeerChangedState (IGKSessionDelegate This, GKSession session, string peerID, GKPeerConnectionState state)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_int (This.Handle, Selector.GetHandle ("session:peer:didChangeState:"), session__handle__, nspeerID, (int)state);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveConnectionRequestFromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerConnectionRequest (GKSession session, string peerID)
		{
			_PeerConnectionRequest (this, session, peerID);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PeerConnectionRequest (IGKSessionDelegate This, GKSession session, string peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveConnectionRequestFromPeer:"), session__handle__, nspeerID);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:connectionWithPeerFailed:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerConnectionFailed (GKSession session, string peerID, NSError error)
		{
			_PeerConnectionFailed (this, session, peerID, error);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PeerConnectionFailed (IGKSessionDelegate This, GKSession session, string peerID, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:connectionWithPeerFailed:withError:"), session__handle__, nspeerID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (GKSession session, NSError error)
		{
			_FailedWithError (this, session, error);
		}
		/// <param name="session">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedWithError (IGKSessionDelegate This, GKSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFailWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("FailedWithError(GameKit.GKSession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("PeerChangedState(GameKit.GKSession,System.String,GameKit.GKPeerConnectionState)")]
		[DynamicDependencyAttribute ("PeerConnectionFailed(GameKit.GKSession,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute ("PeerConnectionRequest(GameKit.GKSession,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKSessionDelegate" /> interface to support all the methods from the GKSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKSessionDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PeerChangedState (this IGKSessionDelegate This, GKSession session, string peerID, GKPeerConnectionState state)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_int (This.Handle, Selector.GetHandle ("session:peer:didChangeState:"), session__handle__, nspeerID, (int)state);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PeerConnectionRequest (this IGKSessionDelegate This, GKSession session, string peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveConnectionRequestFromPeer:"), session__handle__, nspeerID);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PeerConnectionFailed (this IGKSessionDelegate This, GKSession session, string peerID, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (peerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (peerID));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var nspeerID = CFString.CreateNative (peerID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:connectionWithPeerFailed:withError:"), session__handle__, nspeerID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nspeerID);
		}
		/// <param name="session">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedWithError (this IGKSessionDelegate This, GKSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFailWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKSessionDelegateWrapper : BaseWrapper, IGKSessionDelegate {
		public GKSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKSessionDelegateWrapper))]
		static GKSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameKit {
	/// <summary>Delegate for the GKSession class.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKSessionDelegate_Protocol/index.html">Apple documentation for <c>GKSessionDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__GameKit_GKSessionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[ObsoletedOSPlatform ("macos10.10", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'MultipeerConnectivity.MCSessionDelegate' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class GKSessionDelegate : NSObject, IGKSessionDelegate {
		/// <summary>Creates a new <see cref="GKSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKSessionDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
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
		protected GKSessionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal GKSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("session:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedWithError (GKSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("session:peer:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerChangedState (GKSession session, string peerID, GKPeerConnectionState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("session:connectionWithPeerFailed:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerConnectionFailed (GKSession session, string peerID, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveConnectionRequestFromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PeerConnectionRequest (GKSession session, string peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKSessionDelegate */
}
