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
namespace MultipeerConnectivity {
	#pragma warning disable CS1573
	/// <summary>A delegate object whose functions relate to events in the <see cref="T:MultipeerConnectivity.MCSession" /> life-cycle, such as connection status changes and data reception.</summary><remarks><para>Callbacks to the <see cref="T:MultipeerConnectivity.MCSessionDelegate" /> object are likely to be made on background threads. Application developers who wish to update the display must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCSessionDelegateRef/index.html">Apple documentation for <c>MCSessionDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MCSessionDelegate", WrapperType = typeof (MCSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeState", Selector = "session:peer:didChangeState:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (MultipeerConnectivity.MCPeerID), typeof (MultipeerConnectivity.MCSessionState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "session:didReceiveData:fromPeer:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (NSData), typeof (MultipeerConnectivity.MCPeerID) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidStartReceivingResource", Selector = "session:didStartReceivingResourceWithName:fromPeer:withProgress:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (string), typeof (MultipeerConnectivity.MCPeerID), typeof (NSProgress) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishReceivingResource", Selector = "session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (string), typeof (MultipeerConnectivity.MCPeerID), typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveStream", Selector = "session:didReceiveStream:withName:fromPeer:", ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (NSInputStream), typeof (string), typeof (MultipeerConnectivity.MCPeerID) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveCertificate", Selector = "session:didReceiveCertificate:fromPeer:certificateHandler:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MultipeerConnectivity.MCSession), typeof (SecCertificate[]), typeof (MultipeerConnectivity.MCPeerID), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V2) })]
	public partial interface IMCSessionDelegate : INativeObject, IDisposable
	{
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>Indicates that the <paramref name="session" /> has transitioned to the new <paramref name="state" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:peer:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeState (MCSession session, MCPeerID peerID, MCSessionState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>Indicates that the <paramref name="session" /> has transitioned to the new <paramref name="state" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeState (IMCSessionDelegate This, MCSession session, MCPeerID peerID, MCSessionState state)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("session:peer:didChangeState:"), session__handle__, peerID__handle__, (IntPtr) (long) state);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (peerID);
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="data" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:didReceiveData:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (MCSession session, NSData data, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="data" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveData (IMCSessionDelegate This, MCSession session, NSData data, MCPeerID peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveData:fromPeer:"), session__handle__, data__handle__, peerID__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (peerID);
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="progress">To be added.</param><summary>Indicates that <paramref name="resourceName" /> has begun to arrive.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="progress">To be added.</param><summary>Indicates that <paramref name="resourceName" /> has begun to arrive.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStartReceivingResource (IMCSessionDelegate This, MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var fromPeer__handle__ = fromPeer!.GetNonNullHandle (nameof (fromPeer));
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			var nsresourceName = CFString.CreateNative (resourceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didStartReceivingResourceWithName:fromPeer:withProgress:"), session__handle__, nsresourceName, fromPeer__handle__, progress__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (fromPeer);
			GC.KeepAlive (progress);
			CFString.ReleaseNative (nsresourceName);
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="localUrl"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>The error (if any) that occurred during transfer.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the transfer of <paramref name="resourceName" /> has completed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="localUrl"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>The error (if any) that occurred during transfer.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the transfer of <paramref name="resourceName" /> has completed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishReceivingResource (IMCSessionDelegate This, MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var fromPeer__handle__ = fromPeer!.GetNonNullHandle (nameof (fromPeer));
			var localUrl__handle__ = localUrl.GetHandle ();
			var error__handle__ = error.GetHandle ();
			var nsresourceName = CFString.CreateNative (resourceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:"), session__handle__, nsresourceName, fromPeer__handle__, localUrl__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (fromPeer);
			GC.KeepAlive (localUrl);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsresourceName);
		}
		/// <param name="session">To be added.</param><param name="stream">To be added.</param><param name="streamName">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="stream" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("session:didReceiveStream:withName:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveStream (MCSession session, NSInputStream stream, string streamName, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="stream">To be added.</param><param name="streamName">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="stream" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveStream (IMCSessionDelegate This, MCSession session, NSInputStream stream, string streamName, MCPeerID peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var stream__handle__ = stream!.GetNonNullHandle (nameof (stream));
			if (streamName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (streamName));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var nsstreamName = CFString.CreateNative (streamName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveStream:withName:fromPeer:"), session__handle__, stream__handle__, nsstreamName, peerID__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (stream);
			GC.KeepAlive (peerID);
			CFString.ReleaseNative (nsstreamName);
		}
		/// <param name="session">To be added.</param><param name="certificate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="peerID">To be added.</param><param name="certificateHandler">To be added.</param><summary>Indicates <paramref name="peerID" /> wishes to join the <paramref name="session" />. <paramref name="certificateHandler" /> must be called.</summary><returns>To be added.</returns><remarks><para>When overriding this method, the application developer must invoke the <paramref name="certificateHandler" />, passing in <see langword="true" /> if the peer should be accepted to the <paramref name="session" />.</para><para>The Multipeer Connectivity framework makes no attempt to validate passed certificates. It is the application developer's responsibility to ensure their validity.</para></remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveCertificate:fromPeer:certificateHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool DidReceiveCertificate (MCSession session, global::Security.SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> certificateHandler)
		{
			return _DidReceiveCertificate (this, session, certificate, peerID, certificateHandler);
		}
		/// <param name="session">To be added.</param><param name="certificate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="peerID">To be added.</param><param name="certificateHandler">To be added.</param><summary>Indicates <paramref name="peerID" /> wishes to join the <paramref name="session" />. <paramref name="certificateHandler" /> must be called.</summary><returns>To be added.</returns><remarks><para>When overriding this method, the application developer must invoke the <paramref name="certificateHandler" />, passing in <see langword="true" /> if the peer should be accepted to the <paramref name="session" />.</para><para>The Multipeer Connectivity framework makes no attempt to validate passed certificates. It is the application developer's responsibility to ensure their validity.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _DidReceiveCertificate (IMCSessionDelegate This, MCSession session, global::Security.SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> certificateHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			if (certificateHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (certificateHandler));
			using var nsa_certificate = certificate is null ? null : NSArray.FromNSObjects (certificate);
			using var block_certificateHandler = Trampolines.SDActionArity1V2.CreateBlock (certificateHandler);
			BlockLiteral *block_ptr_certificateHandler = &block_certificateHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveCertificate:fromPeer:certificateHandler:"), session__handle__, nsa_certificate.GetHandle (), peerID__handle__, (IntPtr) block_ptr_certificateHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (peerID);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("DidChangeState(MultipeerConnectivity.MCSession,MultipeerConnectivity.MCPeerID,MultipeerConnectivity.MCSessionState)")]
		[DynamicDependencyAttribute ("DidFinishReceivingResource(MultipeerConnectivity.MCSession,System.String,MultipeerConnectivity.MCPeerID,Foundation.NSUrl,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidReceiveCertificate(MultipeerConnectivity.MCSession,Security.SecCertificate[],MultipeerConnectivity.MCPeerID,System.Action{System.Boolean})")]
		[DynamicDependencyAttribute ("DidReceiveData(MultipeerConnectivity.MCSession,Foundation.NSData,MultipeerConnectivity.MCPeerID)")]
		[DynamicDependencyAttribute ("DidReceiveStream(MultipeerConnectivity.MCSession,Foundation.NSInputStream,System.String,MultipeerConnectivity.MCPeerID)")]
		[DynamicDependencyAttribute ("DidStartReceivingResource(MultipeerConnectivity.MCSession,System.String,MultipeerConnectivity.MCPeerID,Foundation.NSProgress)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMCSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMCSessionDelegate" /> interface to support all the methods from the MCSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMCSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MCSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MCSessionDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="certificate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="peerID">To be added.</param><param name="certificateHandler">To be added.</param><summary>Indicates <paramref name="peerID" /> wishes to join the <paramref name="session" />. <paramref name="certificateHandler" /> must be called.</summary><returns>To be added.</returns><remarks><para>When overriding this method, the application developer must invoke the <paramref name="certificateHandler" />, passing in <see langword="true" /> if the peer should be accepted to the <paramref name="session" />.</para><para>The Multipeer Connectivity framework makes no attempt to validate passed certificates. It is the application developer's responsibility to ensure their validity.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool DidReceiveCertificate (this IMCSessionDelegate This, MCSession session, global::Security.SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> certificateHandler)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			if (certificateHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (certificateHandler));
			using var nsa_certificate = certificate is null ? null : NSArray.FromNSObjects (certificate);
			using var block_certificateHandler = Trampolines.SDActionArity1V2.CreateBlock (certificateHandler);
			BlockLiteral *block_ptr_certificateHandler = &block_certificateHandler;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveCertificate:fromPeer:certificateHandler:"), session__handle__, nsa_certificate.GetHandle (), peerID__handle__, (IntPtr) block_ptr_certificateHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (peerID);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MCSessionDelegateWrapper : BaseWrapper, IMCSessionDelegate {
		public MCSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MCSessionDelegateWrapper))]
		static MCSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>Indicates that the <paramref name="session" /> has transitioned to the new <paramref name="state" />.</summary><remarks>To be added.</remarks>
		[Export ("session:peer:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidChangeState (MCSession session, MCPeerID peerID, MCSessionState state)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("session:peer:didChangeState:"), session__handle__, peerID__handle__, (IntPtr) (long) state);
			GC.KeepAlive (session);
			GC.KeepAlive (peerID);
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="data" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveData:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveData (MCSession session, NSData data, MCPeerID peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("session:didReceiveData:fromPeer:"), session__handle__, data__handle__, peerID__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (peerID);
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="progress">To be added.</param><summary>Indicates that <paramref name="resourceName" /> has begun to arrive.</summary><remarks>To be added.</remarks>
		[Export ("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidStartReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var fromPeer__handle__ = fromPeer!.GetNonNullHandle (nameof (fromPeer));
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			var nsresourceName = CFString.CreateNative (resourceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("session:didStartReceivingResourceWithName:fromPeer:withProgress:"), session__handle__, nsresourceName, fromPeer__handle__, progress__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (fromPeer);
			GC.KeepAlive (progress);
			CFString.ReleaseNative (nsresourceName);
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="localUrl"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>The error (if any) that occurred during transfer.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the transfer of <paramref name="resourceName" /> has completed.</summary><remarks>To be added.</remarks>
		[Export ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinishReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (resourceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resourceName));
			var fromPeer__handle__ = fromPeer!.GetNonNullHandle (nameof (fromPeer));
			var localUrl__handle__ = localUrl.GetHandle ();
			var error__handle__ = error.GetHandle ();
			var nsresourceName = CFString.CreateNative (resourceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:"), session__handle__, nsresourceName, fromPeer__handle__, localUrl__handle__, error__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (fromPeer);
			GC.KeepAlive (localUrl);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsresourceName);
		}
		/// <param name="session">To be added.</param><param name="stream">To be added.</param><param name="streamName">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="stream" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveStream:withName:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveStream (MCSession session, NSInputStream stream, string streamName, MCPeerID peerID)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var stream__handle__ = stream!.GetNonNullHandle (nameof (stream));
			if (streamName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (streamName));
			var peerID__handle__ = peerID!.GetNonNullHandle (nameof (peerID));
			var nsstreamName = CFString.CreateNative (streamName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("session:didReceiveStream:withName:fromPeer:"), session__handle__, stream__handle__, nsstreamName, peerID__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (stream);
			GC.KeepAlive (peerID);
			CFString.ReleaseNative (nsstreamName);
		}
	}
}
namespace MultipeerConnectivity {
	/// <summary>A delegate object whose functions relate to events in the <see cref="T:MultipeerConnectivity.MCSession" /> life-cycle, such as connection status changes and data reception.</summary><remarks><para>Callbacks to the <see cref="T:MultipeerConnectivity.MCSessionDelegate" /> object are likely to be made on background threads. Application developers who wish to update the display must use, for instance, <see cref="Foundation.NSObject.InvokeOnMainThread(ObjCRuntime.Selector,Foundation.NSObject)" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MultipeerConnectivity/Reference/MCSessionDelegateRef/index.html">Apple documentation for <c>MCSessionDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__MultipeerConnectivity_MCSessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MCSessionDelegate : NSObject, IMCSessionDelegate {
		/// <summary>Creates a new <see cref="MCSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MCSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected MCSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal MCSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="peerID">To be added.</param><param name="state">To be added.</param><summary>Indicates that the <paramref name="session" /> has transitioned to the new <paramref name="state" />.</summary><remarks>To be added.</remarks>
		[Export ("session:peer:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeState (MCSession session, MCPeerID peerID, MCSessionState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="localUrl"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>The error (if any) that occurred during transfer.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indicates that the transfer of <paramref name="resourceName" /> has completed.</summary><remarks>To be added.</remarks>
		[Export ("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="certificate"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="peerID">To be added.</param><param name="certificateHandler">To be added.</param><summary>Indicates <paramref name="peerID" /> wishes to join the <paramref name="session" />. <paramref name="certificateHandler" /> must be called.</summary><returns>To be added.</returns><remarks><para>When overriding this method, the application developer must invoke the <paramref name="certificateHandler" />, passing in <see langword="true" /> if the peer should be accepted to the <paramref name="session" />.</para><para>The Multipeer Connectivity framework makes no attempt to validate passed certificates. It is the application developer's responsibility to ensure their validity.</para></remarks>
		[Export ("session:didReceiveCertificate:fromPeer:certificateHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool DidReceiveCertificate (MCSession session, global::Security.SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<bool> certificateHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="data" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveData:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (MCSession session, NSData data, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="stream">To be added.</param><param name="streamName">To be added.</param><param name="peerID">To be added.</param><summary>Indicates the arrival of <paramref name="stream" />.</summary><remarks>To be added.</remarks>
		[Export ("session:didReceiveStream:withName:fromPeer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveStream (MCSession session, NSInputStream stream, string streamName, MCPeerID peerID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="resourceName">To be added.</param><param name="fromPeer">To be added.</param><param name="progress">To be added.</param><summary>Indicates that <paramref name="resourceName" /> has begun to arrive.</summary><remarks>To be added.</remarks>
		[Export ("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStartReceivingResource (MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MCSessionDelegate */
}
