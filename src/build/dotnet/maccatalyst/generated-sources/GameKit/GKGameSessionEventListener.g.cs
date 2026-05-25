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
	/// <summary>This interface represents the Objective-C protocol <c>GKGameSessionEventListener</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("macos10.14", "Use 'GKLocalPlayerListener' instead.")]
	[ObsoletedOSPlatform ("tvos12.0", "Use 'GKLocalPlayerListener' instead.")]
	[ObsoletedOSPlatform ("ios12.0", "Use 'GKLocalPlayerListener' instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GKLocalPlayerListener' instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKGameSessionEventListener", WrapperType = typeof (GKGameSessionEventListenerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddPlayer", Selector = "session:didAddPlayer:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (GameKit.GKCloudPlayer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemovePlayer", Selector = "session:didRemovePlayer:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (GameKit.GKCloudPlayer) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeConnectionState", Selector = "session:player:didChangeConnectionState:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (GameKit.GKCloudPlayer), typeof (GameKit.GKConnectionState) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSaveData", Selector = "session:player:didSaveData:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (GameKit.GKCloudPlayer), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "session:didReceiveData:fromPlayer:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (NSData), typeof (GameKit.GKCloudPlayer) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveMessage", Selector = "session:didReceiveMessage:withData:fromPlayer:", ParameterType = new Type [] { typeof (GameKit.GKGameSession), typeof (string), typeof (NSData), typeof (GameKit.GKCloudPlayer) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IGKGameSessionEventListener : INativeObject, IDisposable
	{
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didAddPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidAddPlayer (GKGameSession session, GKCloudPlayer player)
		{
			_DidAddPlayer (this, session, player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidAddPlayer (IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didAddPlayer:"), session__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didRemovePlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidRemovePlayer (GKGameSession session, GKCloudPlayer player)
		{
			_DidRemovePlayer (this, session, player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidRemovePlayer (IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didRemovePlayer:"), session__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="newState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:player:didChangeConnectionState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeConnectionState (GKGameSession session, GKCloudPlayer player, GKConnectionState newState)
		{
			_DidChangeConnectionState (this, session, player, newState);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="newState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeConnectionState (IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, GKConnectionState newState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("session:player:didChangeConnectionState:"), session__handle__, player__handle__, (IntPtr) (long) newState);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:player:didSaveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSaveData (GKGameSession session, GKCloudPlayer player, NSData data)
		{
			_DidSaveData (this, session, player, data);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSaveData (IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, NSData data)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:player:didSaveData:"), session__handle__, player__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
			GC.KeepAlive (data);
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveData:fromPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveData (GKGameSession session, NSData data, GKCloudPlayer player)
		{
			_DidReceiveData (this, session, data, player);
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveData (IGKGameSessionEventListener This, GKGameSession session, NSData data, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveData:fromPlayer:"), session__handle__, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("session:didReceiveMessage:withData:fromPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveMessage (GKGameSession session, string message, NSData data, GKCloudPlayer player)
		{
			_DidReceiveMessage (this, session, message, data, player);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveMessage (IGKGameSessionEventListener This, GKGameSession session, string message, NSData data, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:withData:fromPlayer:"), session__handle__, nsmessage, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
			CFString.ReleaseNative (nsmessage);
		}
		[DynamicDependencyAttribute ("DidAddPlayer(GameKit.GKGameSession,GameKit.GKCloudPlayer)")]
		[DynamicDependencyAttribute ("DidChangeConnectionState(GameKit.GKGameSession,GameKit.GKCloudPlayer,GameKit.GKConnectionState)")]
		[DynamicDependencyAttribute ("DidReceiveData(GameKit.GKGameSession,Foundation.NSData,GameKit.GKCloudPlayer)")]
		[DynamicDependencyAttribute ("DidReceiveMessage(GameKit.GKGameSession,System.String,Foundation.NSData,GameKit.GKCloudPlayer)")]
		[DynamicDependencyAttribute ("DidRemovePlayer(GameKit.GKGameSession,GameKit.GKCloudPlayer)")]
		[DynamicDependencyAttribute ("DidSaveData(GameKit.GKGameSession,GameKit.GKCloudPlayer,Foundation.NSData)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameSessionEventListenerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKGameSessionEventListener ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKGameSessionEventListener" /> interface to support all the methods from the GKGameSessionEventListener protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKGameSessionEventListener" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKGameSessionEventListener protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKGameSessionEventListener_Extensions {
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidAddPlayer (this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didAddPlayer:"), session__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidRemovePlayer (this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didRemovePlayer:"), session__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="newState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeConnectionState (this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, GKConnectionState newState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("session:player:didChangeConnectionState:"), session__handle__, player__handle__, (IntPtr) (long) newState);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="player">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSaveData (this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, NSData data)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:player:didSaveData:"), session__handle__, player__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (player);
			GC.KeepAlive (data);
		}
		/// <param name="session">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveData (this IGKGameSessionEventListener This, GKGameSession session, NSData data, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveData:fromPlayer:"), session__handle__, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
		}
		/// <param name="session">To be added.</param><param name="message">To be added.</param><param name="data">To be added.</param><param name="player">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReceiveMessage (this IGKGameSessionEventListener This, GKGameSession session, string message, NSData data, GKCloudPlayer player)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("session:didReceiveMessage:withData:fromPlayer:"), session__handle__, nsmessage, data__handle__, player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (data);
			GC.KeepAlive (player);
			CFString.ReleaseNative (nsmessage);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKGameSessionEventListenerWrapper : BaseWrapper, IGKGameSessionEventListener {
		public GKGameSessionEventListenerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameSessionEventListenerWrapper))]
		static GKGameSessionEventListenerWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
