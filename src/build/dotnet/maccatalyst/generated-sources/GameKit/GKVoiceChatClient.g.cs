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
	#pragma warning disable CS1573
	/// <summary>The model that GKVoiceChatService uses.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKVoiceChatClient_Protocol/index.html">Apple documentation for <c>GKVoiceChatClient</c></related>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'GKVoiceChat' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKVoiceChat' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "GKVoiceChatClient", WrapperType = typeof (GKVoiceChatClientWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendData", Selector = "voiceChatService:sendData:toParticipantID:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (NSData), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ParticipantID", Selector = "participantID", ReturnType = typeof (string))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SendRealTimeData", Selector = "voiceChatService:sendRealTimeData:toParticipantID:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (NSData), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Started", Selector = "voiceChatService:didStartWithParticipantID:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToConnect", Selector = "voiceChatService:didNotStartWithParticipantID:error:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Stopped", Selector = "voiceChatService:didStopWithParticipantID:error:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedInvitation", Selector = "voiceChatService:didReceiveInvitationFromParticipantID:callID:", ParameterType = new Type [] { typeof (GameKit.GKVoiceChatService), typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IGKVoiceChatClient : INativeObject, IDisposable
	{
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="toParticipant">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("voiceChatService:sendData:toParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendData (GKVoiceChatService voiceChatService, NSData data, string toParticipant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="toParticipant">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SendData (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, NSData data, string toParticipant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (toParticipant is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (toParticipant));
			var nstoParticipant = CFString.CreateNative (toParticipant);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:sendData:toParticipantID:"), voiceChatService__handle__, data__handle__, nstoParticipant);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstoParticipant);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("participantID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ParticipantID ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _ParticipantID (IGKVoiceChatClient This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("participantID")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("voiceChatService:sendRealTimeData:toParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendRealTimeData (GKVoiceChatService voiceChatService, NSData data, string participantID)
		{
			_SendRealTimeData (this, voiceChatService, data, participantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SendRealTimeData (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, NSData data, string participantID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:sendRealTimeData:toParticipantID:"), voiceChatService__handle__, data__handle__, nsparticipantID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("voiceChatService:didStartWithParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Started (GKVoiceChatService voiceChatService, string participantID)
		{
			_Started (this, voiceChatService, participantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Started (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didStartWithParticipantID:"), voiceChatService__handle__, nsparticipantID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("voiceChatService:didNotStartWithParticipantID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToConnect (GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			_FailedToConnect (this, voiceChatService, participantID, error);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToConnect (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var error__handle__ = error.GetHandle ();
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didNotStartWithParticipantID:error:"), voiceChatService__handle__, nsparticipantID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("voiceChatService:didStopWithParticipantID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			_Stopped (this, voiceChatService, participantID, error);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Stopped (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var error__handle__ = error.GetHandle ();
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didStopWithParticipantID:error:"), voiceChatService__handle__, nsparticipantID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="callID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("voiceChatService:didReceiveInvitationFromParticipantID:callID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedInvitation (GKVoiceChatService voiceChatService, string participantID, nint callID)
		{
			_ReceivedInvitation (this, voiceChatService, participantID, callID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="callID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedInvitation (IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, nint callID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("voiceChatService:didReceiveInvitationFromParticipantID:callID:"), voiceChatService__handle__, nsparticipantID, callID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			CFString.ReleaseNative (nsparticipantID);
		}
		[DynamicDependencyAttribute ("FailedToConnect(GameKit.GKVoiceChatService,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute ("ParticipantID()")]
		[DynamicDependencyAttribute ("ReceivedInvitation(GameKit.GKVoiceChatService,System.String,System.IntPtr)")]
		[DynamicDependencyAttribute ("SendData(GameKit.GKVoiceChatService,Foundation.NSData,System.String)")]
		[DynamicDependencyAttribute ("SendRealTimeData(GameKit.GKVoiceChatService,Foundation.NSData,System.String)")]
		[DynamicDependencyAttribute ("Started(GameKit.GKVoiceChatService,System.String)")]
		[DynamicDependencyAttribute ("Stopped(GameKit.GKVoiceChatService,System.String,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKVoiceChatClientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKVoiceChatClient ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKVoiceChatClient" /> interface to support all the methods from the GKVoiceChatClient protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKVoiceChatClient" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKVoiceChatClient protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKVoiceChatClient_Extensions {
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SendRealTimeData (this IGKVoiceChatClient This, GKVoiceChatService voiceChatService, NSData data, string participantID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:sendRealTimeData:toParticipantID:"), voiceChatService__handle__, data__handle__, nsparticipantID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Started (this IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didStartWithParticipantID:"), voiceChatService__handle__, nsparticipantID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToConnect (this IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var error__handle__ = error.GetHandle ();
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didNotStartWithParticipantID:error:"), voiceChatService__handle__, nsparticipantID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Stopped (this IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var error__handle__ = error.GetHandle ();
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("voiceChatService:didStopWithParticipantID:error:"), voiceChatService__handle__, nsparticipantID, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nsparticipantID);
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="callID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedInvitation (this IGKVoiceChatClient This, GKVoiceChatService voiceChatService, string participantID, nint callID)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			if (participantID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (participantID));
			var nsparticipantID = CFString.CreateNative (participantID);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("voiceChatService:didReceiveInvitationFromParticipantID:callID:"), voiceChatService__handle__, nsparticipantID, callID);
			GC.KeepAlive (This);
			GC.KeepAlive (voiceChatService);
			CFString.ReleaseNative (nsparticipantID);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKVoiceChatClientWrapper : BaseWrapper, IGKVoiceChatClient {
		public GKVoiceChatClientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKVoiceChatClientWrapper))]
		static GKVoiceChatClientWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="toParticipant">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:sendData:toParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SendData (GKVoiceChatService voiceChatService, NSData data, string toParticipant)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var voiceChatService__handle__ = voiceChatService!.GetNonNullHandle (nameof (voiceChatService));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (toParticipant is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (toParticipant));
			var nstoParticipant = CFString.CreateNative (toParticipant);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("voiceChatService:sendData:toParticipantID:"), voiceChatService__handle__, data__handle__, nstoParticipant);
			GC.KeepAlive (voiceChatService);
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstoParticipant);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("participantID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string ParticipantID ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("participantID")), false)!;
			return ret;
		}
	}
}
namespace GameKit {
	/// <summary>The model that GKVoiceChatService uses.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameKit/Reference/GKVoiceChatClient_Protocol/index.html">Apple documentation for <c>GKVoiceChatClient</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__GameKit_GKVoiceChatClient", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[ObsoletedOSPlatform ("ios7.0", "Use 'GKVoiceChat' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKVoiceChat' instead.")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class GKVoiceChatClient : NSObject, IGKVoiceChatClient {
		/// <summary>Creates a new <see cref="GKVoiceChatClient" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected GKVoiceChatClient () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected GKVoiceChatClient (NSObjectFlag t) : base (t)
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
		protected internal GKVoiceChatClient (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:didNotStartWithParticipantID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToConnect (GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("participantID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ParticipantID ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="callID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:didReceiveInvitationFromParticipantID:callID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedInvitation (GKVoiceChatService voiceChatService, string participantID, nint callID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="toParticipant">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:sendData:toParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendData (GKVoiceChatService voiceChatService, NSData data, string toParticipant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="data">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:sendRealTimeData:toParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendRealTimeData (GKVoiceChatService voiceChatService, NSData data, string participantID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:didStartWithParticipantID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Started (GKVoiceChatService voiceChatService, string participantID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="voiceChatService">To be added.</param><param name="participantID">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("voiceChatService:didStopWithParticipantID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stopped (GKVoiceChatService voiceChatService, string participantID, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKVoiceChatClient */
}
