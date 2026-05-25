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
namespace NetworkExtension {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	internal unsafe static partial class NEVpnConnectionStartOptionInternal  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Password;
		/// <summary>Represents the value associated with the constant 'NEVPNConnectionStartOptionPassword'.</summary>
		[Field ("NEVPNConnectionStartOptionPassword",  "NetworkExtension")]
		public static NSString Password {
			get {
				if (_Password is null)
					_Password = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NEVPNConnectionStartOptionPassword")!;
				return _Password;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Username;
		/// <summary>Represents the value associated with the constant 'NEVPNConnectionStartOptionUsername'.</summary>
		[Field ("NEVPNConnectionStartOptionUsername",  "NetworkExtension")]
		public static NSString Username {
			get {
				if (_Username is null)
					_Username = Dlfcn.GetStringConstant (Libraries.NetworkExtension.Handle, "NEVPNConnectionStartOptionUsername")!;
				return _Username;
			}
		}
	} /* class NEVpnConnectionStartOptionInternal */
}
