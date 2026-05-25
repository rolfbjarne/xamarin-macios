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
namespace CoreBluetooth {
	internal unsafe static partial class CBConnectPeripheralOptionsKeys  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EnableAutoReconnectKey;
		/// <summary>Represents the value associated with the constant 'CBConnectPeripheralOptionEnableAutoReconnect'.</summary>
		[Field ("CBConnectPeripheralOptionEnableAutoReconnect",  "CoreBluetooth")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static NSString EnableAutoReconnectKey {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("macos14.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				if (_EnableAutoReconnectKey is null)
					_EnableAutoReconnectKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionEnableAutoReconnect")!;
				return _EnableAutoReconnectKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotifyOnConnectionKey;
		/// <summary>Represents the value associated with the constant 'CBConnectPeripheralOptionNotifyOnConnectionKey'.</summary>
		[Field ("CBConnectPeripheralOptionNotifyOnConnectionKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NotifyOnConnectionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NotifyOnConnectionKey is null)
					_NotifyOnConnectionKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnConnectionKey")!;
				return _NotifyOnConnectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotifyOnDisconnectionKey;
		/// <summary>Represents the value associated with the constant 'CBConnectPeripheralOptionNotifyOnDisconnectionKey'.</summary>
		[Field ("CBConnectPeripheralOptionNotifyOnDisconnectionKey",  "CoreBluetooth")]
		public static NSString NotifyOnDisconnectionKey {
			get {
				if (_NotifyOnDisconnectionKey is null)
					_NotifyOnDisconnectionKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnDisconnectionKey")!;
				return _NotifyOnDisconnectionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NotifyOnNotificationKey;
		/// <summary>Represents the value associated with the constant 'CBConnectPeripheralOptionNotifyOnNotificationKey'.</summary>
		[Field ("CBConnectPeripheralOptionNotifyOnNotificationKey",  "CoreBluetooth")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NotifyOnNotificationKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NotifyOnNotificationKey is null)
					_NotifyOnNotificationKey = Dlfcn.GetStringConstant (Libraries.CoreBluetooth.Handle, "CBConnectPeripheralOptionNotifyOnNotificationKey")!;
				return _NotifyOnNotificationKey;
			}
		}
	} /* class CBConnectPeripheralOptionsKeys */
}
