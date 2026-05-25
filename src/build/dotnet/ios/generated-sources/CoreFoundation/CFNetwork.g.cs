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
namespace CoreFoundation {
	/// <summary>Provides the necessary methods needed for accessing the system's global proxy configuration settings and resolving a list of proxies to use for connecting to a URL.</summary>
	public unsafe partial class CFNetwork  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCFErrorDomainCFNetwork",  "CFNetwork")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFErrorDomainCFNetwork")!;
				return _ErrorDomain;
			}
		}
	} /* class CFNetwork */
}
