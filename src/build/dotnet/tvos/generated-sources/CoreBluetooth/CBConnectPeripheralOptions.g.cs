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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool? EnableTransportBridging {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.EnableTransportBridgingKey!);
			}
			set {
				SetBooleanValue (CBConnectPeripheralOptionsKeys.EnableTransportBridgingKey!, value);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool? RequiresAncs {
			get {
				return  GetBoolValue (CBConnectPeripheralOptionsKeys.RequiresAncsKey!);
			}
			set {
				SetBooleanValue (CBConnectPeripheralOptionsKeys.RequiresAncsKey!, value);
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
