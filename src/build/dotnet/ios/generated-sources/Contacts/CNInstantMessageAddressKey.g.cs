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
namespace Contacts {
	/// <summary>Provides string constants whose values are the common properties of all instant-message providers.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNInstantMessageAddressKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Service;
		/// <summary>A key identifying the <see cref="P:Contacts.CNInstantMessageAddress.Service" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageAddressServiceKey",  "Contacts")]
		public static NSString Service {
			get {
				if (_Service is null)
					_Service = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageAddressServiceKey")!;
				return _Service;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Username;
		/// <summary>A key identifying the <see cref="P:Contacts.CNInstantMessageAddress.Username" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNInstantMessageAddressUsernameKey",  "Contacts")]
		public static NSString Username {
			get {
				if (_Username is null)
					_Username = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNInstantMessageAddressUsernameKey")!;
				return _Username;
			}
		}
	} /* class CNInstantMessageAddressKey */
}
