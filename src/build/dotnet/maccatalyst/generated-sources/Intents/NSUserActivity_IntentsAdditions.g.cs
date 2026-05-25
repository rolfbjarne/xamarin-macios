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
namespace Intents {
	/// <summary>Optional methods for the <see cref="T:Foundation.NSUserActivity" /> interface.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class NSUserActivity_IntentsAdditions  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUserActivity");
		/// <summary>Retrieves the <see cref="T:Intents.INInteraction" /> associated with <c>this</c><see cref="T:Foundation.NSUserActivity" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks><param name="This">The instance on which this method operates.</param>
		[Export ("interaction")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INInteraction? GetInteraction (this NSUserActivity This)
		{
			INInteraction ret;
			ret =  Runtime.GetNSObject<INInteraction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("interaction")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("shortcutAvailability")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INShortcutAvailabilityOptions GetShortcutAvailability (this NSUserActivity This)
		{
			INShortcutAvailabilityOptions ret;
			ret = (Intents.INShortcutAvailabilityOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("shortcutAvailability"));
			GC.KeepAlive (This);
			return ret!;
		}
		[Export ("suggestedInvocationPhrase")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetSuggestedInvocationPhrase (this NSUserActivity This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedInvocationPhrase")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[Export ("setShortcutAvailability:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetShortcutAvailability (this NSUserActivity This, INShortcutAvailabilityOptions shortcutAvailabilityOptions)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setShortcutAvailability:"), (UIntPtr) (ulong) shortcutAvailabilityOptions);
			GC.KeepAlive (This);
		}
		[Export ("setSuggestedInvocationPhrase:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSuggestedInvocationPhrase (this NSUserActivity This, string? suggestedInvocationPhrase)
		{
			var nssuggestedInvocationPhrase = CFString.CreateNative (suggestedInvocationPhrase);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSuggestedInvocationPhrase:"), nssuggestedInvocationPhrase);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssuggestedInvocationPhrase);
		}
	} /* class NSUserActivity_IntentsAdditions */
}
