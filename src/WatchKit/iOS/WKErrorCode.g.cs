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
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
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

namespace WatchKit {
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	[Native]
	public enum WKErrorCode : long {
		None = 0,
		UnknownError = 1,
		RequestReplyNotCalledError = 2,
		InvalidArgumentError = 3,
		MediaPlayerError = 4,
		DownloadError = 5,
		RecordingFailedError = 6,
	}
	
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class WKErrorCodeExtensions {
		[Field ("WatchKitErrorDomain", "WatchKit")]
		static NSString _domain;
		
		public static NSString GetDomain (this WKErrorCode self)
		{
			if (_domain == null)
				_domain = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "WatchKitErrorDomain");
			return _domain;
		}
	}
}
