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
	public partial class CBConnectPeripheralOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CBConnectPeripheralOptions" /> with default (empty) values.</summary>
		public CBConnectPeripheralOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CBConnectPeripheralOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CBConnectPeripheralOptions (NSDictionary? dictionary) : base (dictionary) {}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? NotifyOnConnection {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.NotifyOnConnectionKey!);
			}
			set {
				SetBooleanValue (CBConnectPeripheralOptionsKeys.NotifyOnConnectionKey!, value);
			}
		}
		public bool? NotifyOnDisconnection {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.NotifyOnDisconnectionKey!);
			}
			set {
				SetBooleanValue (CBConnectPeripheralOptionsKeys.NotifyOnDisconnectionKey!, value);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool? NotifyOnNotification {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.NotifyOnNotificationKey!);
			}
			set {
				SetBooleanValue (CBConnectPeripheralOptionsKeys.NotifyOnNotificationKey!, value);
			}
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public bool? EnableAutoReconnect {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.EnableAutoReconnectKey!);
			}
		}
#endif
	}
}
