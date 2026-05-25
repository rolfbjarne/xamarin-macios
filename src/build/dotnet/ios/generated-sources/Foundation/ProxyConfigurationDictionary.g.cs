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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class ProxyConfigurationDictionary : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="ProxyConfigurationDictionary" /> with default (empty) values.</summary>
		public ProxyConfigurationDictionary () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="ProxyConfigurationDictionary" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public ProxyConfigurationDictionary (NSDictionary? dictionary) : base (dictionary) {}
		public bool? HttpEnable {
			get {
				return  GetBoolValue (ProxyConfigurationDictionaryKeys.HttpEnableKey!);
			}
			set {
				SetBooleanValue (ProxyConfigurationDictionaryKeys.HttpEnableKey!, value);
			}
		}
		public string? HttpProxyHost {
			get {
				return GetStringValue (ProxyConfigurationDictionaryKeys.HttpProxyHostKey!);
			}
			set {
				SetStringValue (ProxyConfigurationDictionaryKeys.HttpProxyHostKey!, value);
			}
		}
		public int? HttpProxyPort {
			get {
				return  GetInt32Value (ProxyConfigurationDictionaryKeys.HttpProxyPortKey!);
			}
			set {
				SetNumberValue (ProxyConfigurationDictionaryKeys.HttpProxyPortKey!, value);
			}
		}
		public string? HttpsProxyHost {
			get {
				return GetStringValue (ProxyConfigurationDictionaryKeys.HttpsProxyHostKey!);
			}
			set {
				SetStringValue (ProxyConfigurationDictionaryKeys.HttpsProxyHostKey!, value);
			}
		}
		public int? HttpsProxyPort {
			get {
				return  GetInt32Value (ProxyConfigurationDictionaryKeys.HttpsProxyPortKey!);
			}
			set {
				SetNumberValue (ProxyConfigurationDictionaryKeys.HttpsProxyPortKey!, value);
			}
		}
#endif
	}
}
