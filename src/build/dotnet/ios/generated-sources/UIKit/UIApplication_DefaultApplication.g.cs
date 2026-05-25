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
namespace UIKit {
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios18.2")]
	public unsafe static partial class UIApplication_DefaultApplication  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIApplication");
		[Export ("defaultStatusForCategory:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static UIApplicationCategoryDefaultStatus GetDefaultStatus (this UIApplication This, UIApplicationCategory category, out NSError? error)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NativeHandle errorValue = IntPtr.Zero;
			UIApplicationCategoryDefaultStatus ret;
			ret = (UIApplicationCategoryDefaultStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_ref_NativeHandle (This.Handle, Selector.GetHandle ("defaultStatusForCategory:error:"), (IntPtr) (long) category, &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	} /* class UIApplication_DefaultApplication */
}
