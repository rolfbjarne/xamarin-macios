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
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class AdvertisementData : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="AdvertisementData" /> with default (empty) values.</summary>
		public AdvertisementData () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="AdvertisementData" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public AdvertisementData (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public string? LocalName {
			get {
				return GetStringValue (AdvertisementDataKeys.LocalNameKey!);
			}
			set {
				SetStringValue (AdvertisementDataKeys.LocalNameKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSData? ManufacturerData {
			get {
				return Dictionary [AdvertisementDataKeys.ManufacturerDataKey!] as Foundation.NSData;
			}
			set {
				SetNativeValue (AdvertisementDataKeys.ManufacturerDataKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary<CBUUID, NSData>? ServiceData {
			get {
				return GetNSDictionary <CBUUID, NSData> (AdvertisementDataKeys.ServiceDataKey!);
			}
			set {
				SetNativeValue (AdvertisementDataKeys.ServiceDataKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CBUUID[]? ServiceUuids {
			get {
				return GetArray<CBUUID> (AdvertisementDataKeys.ServiceUuidsKey!);
			}
			set {
				SetArrayValue (AdvertisementDataKeys.ServiceUuidsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CBUUID[]? OverflowServiceUuids {
			get {
				return GetArray<CBUUID> (AdvertisementDataKeys.OverflowServiceUuidsKey!);
			}
			set {
				SetArrayValue (AdvertisementDataKeys.OverflowServiceUuidsKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSNumber? TxPowerLevel {
			get {
				return Dictionary [AdvertisementDataKeys.TxPowerLevelKey!] as Foundation.NSNumber;
			}
			set {
				SetNativeValue (AdvertisementDataKeys.TxPowerLevelKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? IsConnectable {
			get {
				return  GetBoolValue (AdvertisementDataKeys.IsConnectableKey!);
			}
			set {
				SetBooleanValue (AdvertisementDataKeys.IsConnectableKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public CBUUID[]? SolicitedServiceUuids {
			get {
				return GetArray<CBUUID> (AdvertisementDataKeys.SolicitedServiceUuidsKey!);
			}
			set {
				SetArrayValue (AdvertisementDataKeys.SolicitedServiceUuidsKey!, value);
			}
		}
#endif
	}
}
