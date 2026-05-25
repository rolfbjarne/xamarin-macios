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
namespace UserNotificationsUI {
	#pragma warning disable CS1573
	/// <summary>Interface that contains the mandatory methods, if any, for the <see cref="T:UserNotifications.UNNotificationContent" /> protocol, which is required for displaying notification content from a view controller's view with custom UI.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "UNNotificationContentExtension", WrapperType = typeof (UNNotificationContentExtensionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveNotification", Selector = "didReceiveNotification:", ParameterType = new Type [] { typeof (UserNotifications.UNNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveNotificationResponse", Selector = "didReceiveNotificationResponse:completionHandler:", ParameterType = new Type [] { typeof (UserNotifications.UNNotificationResponse), typeof (global::System.Action<global::UserNotificationsUI.UNNotificationContentExtensionResponseOption>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V126) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PlayMedia", Selector = "mediaPlay")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PauseMedia", Selector = "mediaPause")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaPlayPauseButtonType", Selector = "mediaPlayPauseButtonType", PropertyType = typeof (UserNotificationsUI.UNNotificationContentExtensionMediaPlayPauseButtonType), GetterSelector = "mediaPlayPauseButtonType", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaPlayPauseButtonFrame", Selector = "mediaPlayPauseButtonFrame", PropertyType = typeof (CGRect), GetterSelector = "mediaPlayPauseButtonFrame", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MediaPlayPauseButtonTintColor", Selector = "mediaPlayPauseButtonTintColor", PropertyType = typeof (NSColor), GetterSelector = "mediaPlayPauseButtonTintColor", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUNNotificationContentExtension : INativeObject, IDisposable
	{
		/// <param name="notification">The notification that was sent.</param><summary>Method that is called when the application is sent a notification.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didReceiveNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReceiveNotification (global::UserNotifications.UNNotification notification)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="notification">The notification that was sent.</param><summary>Method that is called when the application is sent a notification.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReceiveNotification (IUNNotificationContentExtension This, global::UserNotifications.UNNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveNotification:"), notification__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (notification);
		}
		/// <param name="response">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("didReceiveNotificationResponse:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveNotificationResponse (global::UserNotifications.UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<UNNotificationContentExtensionResponseOption> completion)
		{
			_DidReceiveNotificationResponse (this, response, completion);
		}
		/// <param name="response">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveNotificationResponse (IUNNotificationContentExtension This, global::UserNotifications.UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<UNNotificationContentExtensionResponseOption> completion)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveNotificationResponse:completionHandler:"), response__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (response);
		}
		/// <summary>Method that is called when the user presses the play button.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mediaPlay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PlayMedia ()
		{
			_PlayMedia (this);
		}
		/// <summary>Method that is called when the user presses the play button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PlayMedia (IUNNotificationContentExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlay"));
			GC.KeepAlive (This);
		}
		/// <summary>Method that is called when the user presses the pause button.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mediaPause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PauseMedia ()
		{
			_PauseMedia (this);
		}
		/// <summary>Method that is called when the user presses the pause button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PauseMedia (IUNNotificationContentExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPause"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DidReceiveNotification(UserNotifications.UNNotification)")]
		[DynamicDependencyAttribute ("DidReceiveNotificationResponse(UserNotifications.UNNotificationResponse,System.Action{UserNotificationsUI.UNNotificationContentExtensionResponseOption})")]
		[DynamicDependencyAttribute ("MediaPlayPauseButtonFrame")]
		[DynamicDependencyAttribute ("MediaPlayPauseButtonTintColor")]
		[DynamicDependencyAttribute ("MediaPlayPauseButtonType")]
		[DynamicDependencyAttribute ("PauseMedia()")]
		[DynamicDependencyAttribute ("PlayMedia()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UNNotificationContentExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUNNotificationContentExtension ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual UNNotificationContentExtensionMediaPlayPauseButtonType MediaPlayPauseButtonType {
			[Export ("mediaPlayPauseButtonType", ArgumentSemantic.Assign)]
			get {
				return _GetMediaPlayPauseButtonType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UNNotificationContentExtensionMediaPlayPauseButtonType _GetMediaPlayPauseButtonType (IUNNotificationContentExtension This)
		{
			UNNotificationContentExtensionMediaPlayPauseButtonType ret;
			ret = (UserNotificationsUI.UNNotificationContentExtensionMediaPlayPauseButtonType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the rectangle that will be used to display a playback button.</summary><returns>The rectangle that will be used to display a playback button.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual CGRect MediaPlayPauseButtonFrame {
			[Export ("mediaPlayPauseButtonFrame", ArgumentSemantic.Assign)]
			get {
				return _GetMediaPlayPauseButtonFrame (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetMediaPlayPauseButtonFrame (IUNNotificationContentExtension This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonFrame"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonFrame"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>Returns the tint color of the playback button.</summary><returns>The tint color of the playback button.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::AppKit.NSColor MediaPlayPauseButtonTintColor {
			[Export ("mediaPlayPauseButtonTintColor", ArgumentSemantic.Copy)]
			get {
				return _GetMediaPlayPauseButtonTintColor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSColor _GetMediaPlayPauseButtonTintColor (IUNNotificationContentExtension This)
		{
			global::AppKit.NSColor ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonTintColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUNNotificationContentExtension" /> interface to support all the methods from the UNNotificationContentExtension protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUNNotificationContentExtension" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UNNotificationContentExtension protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UNNotificationContentExtension_Extensions {
		/// <param name="response">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveNotificationResponse (this IUNNotificationContentExtension This, global::UserNotifications.UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<UNNotificationContentExtensionResponseOption> completion)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didReceiveNotificationResponse:completionHandler:"), response__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (response);
		}
		/// <summary>Method that is called when the user presses the play button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PlayMedia (this IUNNotificationContentExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlay"));
			GC.KeepAlive (This);
		}
		/// <summary>Method that is called when the user presses the pause button.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PauseMedia (this IUNNotificationContentExtension This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPause"));
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UNNotificationContentExtensionMediaPlayPauseButtonType GetMediaPlayPauseButtonType (this IUNNotificationContentExtension This)
		{
			UNNotificationContentExtensionMediaPlayPauseButtonType ret;
			ret = (UserNotificationsUI.UNNotificationContentExtensionMediaPlayPauseButtonType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Returns the rectangle that will be used to display a playback button.</summary><returns>The rectangle that will be used to display a playback button.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGRect GetMediaPlayPauseButtonFrame (this IUNNotificationContentExtension This)
		{
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonFrame"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonFrame"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>Returns the tint color of the playback button.</summary><returns>The tint color of the playback button.</returns>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSColor GetMediaPlayPauseButtonTintColor (this IUNNotificationContentExtension This)
		{
			global::AppKit.NSColor ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("mediaPlayPauseButtonTintColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UNNotificationContentExtensionWrapper : BaseWrapper, IUNNotificationContentExtension {
		public UNNotificationContentExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UNNotificationContentExtensionWrapper))]
		static UNNotificationContentExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="notification">The notification that was sent.</param><summary>Method that is called when the application is sent a notification.</summary><remarks>To be added.</remarks>
		[Export ("didReceiveNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidReceiveNotification (global::UserNotifications.UNNotification notification)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didReceiveNotification:"), notification__handle__);
			GC.KeepAlive (notification);
		}
	}
}
