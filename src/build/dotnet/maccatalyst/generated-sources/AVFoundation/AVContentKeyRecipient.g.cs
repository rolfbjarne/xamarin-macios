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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Interface defining required methods that require decryption keys for media data processing.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVContentKeyRecipient", WrapperType = typeof (AVContentKeyRecipientWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProvideContentKey", Selector = "contentKeySession:didProvideContentKey:", ParameterType = new Type [] { typeof (AVContentKeySession), typeof (AVContentKey) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MayRequireContentKeysForMediaDataProcessing", Selector = "mayRequireContentKeysForMediaDataProcessing", PropertyType = typeof (bool), GetterSelector = "mayRequireContentKeysForMediaDataProcessing", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IAVContentKeyRecipient : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("contentKeySession:didProvideContentKey:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProvideContentKey (AVContentKeySession contentKeySession, AVContentKey contentKey)
		{
			_DidProvideContentKey (this, contentKeySession, contentKey);
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProvideContentKey (IAVContentKeyRecipient This, AVContentKeySession contentKeySession, AVContentKey contentKey)
		{
			var contentKeySession__handle__ = contentKeySession!.GetNonNullHandle (nameof (contentKeySession));
			var contentKey__handle__ = contentKey!.GetNonNullHandle (nameof (contentKey));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKey:"), contentKeySession__handle__, contentKey__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentKeySession);
			GC.KeepAlive (contentKey);
		}
		[DynamicDependencyAttribute ("DidProvideContentKey(AVFoundation.AVContentKeySession,AVFoundation.AVContentKey)")]
		[DynamicDependencyAttribute ("MayRequireContentKeysForMediaDataProcessing")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContentKeyRecipientWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVContentKeyRecipient ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool MayRequireContentKeysForMediaDataProcessing {
			[Export ("mayRequireContentKeysForMediaDataProcessing")]
			get {
				return _GetMayRequireContentKeysForMediaDataProcessing (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetMayRequireContentKeysForMediaDataProcessing (IAVContentKeyRecipient This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("mayRequireContentKeysForMediaDataProcessing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVContentKeyRecipient" /> interface to support all the methods from the AVContentKeyRecipient protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVContentKeyRecipient" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVContentKeyRecipient protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVContentKeyRecipient_Extensions {
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProvideContentKey (this IAVContentKeyRecipient This, AVContentKeySession contentKeySession, AVContentKey contentKey)
		{
			var contentKeySession__handle__ = contentKeySession!.GetNonNullHandle (nameof (contentKeySession));
			var contentKey__handle__ = contentKey!.GetNonNullHandle (nameof (contentKey));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentKeySession:didProvideContentKey:"), contentKeySession__handle__, contentKey__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentKeySession);
			GC.KeepAlive (contentKey);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVContentKeyRecipientWrapper : BaseWrapper, IAVContentKeyRecipient {
		public AVContentKeyRecipientWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVContentKeyRecipientWrapper))]
		static AVContentKeyRecipientWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool MayRequireContentKeysForMediaDataProcessing {
			[Export ("mayRequireContentKeysForMediaDataProcessing")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mayRequireContentKeysForMediaDataProcessing"));
				return ret != 0;
			}
		}
	}
}
